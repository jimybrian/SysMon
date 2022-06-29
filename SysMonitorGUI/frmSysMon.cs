using Microsoft.AspNetCore.SignalR.Client;
using SysMonitorGUI.SysMon;
using SysMonitorGUI.SysMon.WMIObjects;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysMonitorGUI
{
    public partial class frmSysMon : Form
    {
        Timer timer;
        SystemMonitorRepo sRepo = new SystemMonitorRepo();

        DataSender dataSender;

        int frequency = 10000;
        string url = "";

        public frmSysMon()
        {
            InitializeComponent();

            frequency = Properties.Settings.Default.sendFrequency;
            url = Properties.Settings.Default.url;

            txUrl.Text = url;

            dataSender = new DataSender(url);

            dataSender.connection.Closed += async (exception) =>
            {

                lblState.Invoke((MethodInvoker)delegate
                {
                    // Running on the UI thread
                    lblState.Text = "Connection Stopped";
                });
            };


            dataSender.connection
                .On<SysInfoItem>("SendSysInfo", data => { Debug.WriteLine("Recieved Data: " + data.pcName); });
        }

        private async void frmSysMon_Load(object sender, EventArgs e)
        {
            await getData();
            setupTimerTask();
        }          
        
        void setupTimerTask()
        {
            timer = new Timer();
            timer.Interval = frequency;
            timer.Start();

            timer.Tick += async (s, e) =>
            {
                await getData();
            };
        }

        async Task getData()
        {
            var data = sRepo.GetSystemInfo();

            if (data != null)
            {
                lblCPUSpeed.Text = data.cpuClock;
                lblCPUUsage.Text = data.cpuUsageVal;
                lblCPUTemp.Text = data.cpuTempVal;
                lblGPUUsage.Text = data.gpuUsageVal;
                lblGPUTemp.Text = data.gpuTempVal;
                lblRAMUsage.Text = data.ramUsage;
                lblRAMTotal.Text = data.ramTotal;
                lblPCName.Text = data.pcName;

                prUsage.Value = (int)Math.Round(double.Parse(data.cpuUsageVal));
                prRAMUse.Value = (int)Math.Round(double.Parse(data.ramUsage));


                if (dataSender.connection.State == HubConnectionState.Connected)
                    await dataSender.connection.InvokeAsync("SendSysInfo", data);
            }
        }

        private void frmSysMon_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            dataSender.connection.StopAsync();
        }


     

        private void trkFrequency_Scroll(object sender, EventArgs e)
        {
            Debug.Write("Frequency Step: ");
            Debug.WriteLine(trkFrequency.Value);
        }

        private async void btnSendData_Click(object sender, EventArgs e)
        {           
            if (dataSender.connection.State != HubConnectionState.Connected)
                await dataSender.connection.StartAsync();
            else
                await dataSender.connection.StopAsync();
        }

        private void frmSysMon_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                ntfSysMon.Visible = true;
            }
            
        }

        private void ntfSysMon_DoubleClick(object sender, EventArgs e)
        {            
            Show();

            ntfSysMon.Visible = false;
        }
    }
}
