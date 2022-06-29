
namespace SysMonitorGUI
{
    partial class frmSysMon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSysMon));
            this.grbStats = new System.Windows.Forms.GroupBox();
            this.lblPCName = new System.Windows.Forms.Label();
            this.lblRAMTotal = new System.Windows.Forms.Label();
            this.lblRAMUsage = new System.Windows.Forms.Label();
            this.lblGPUTemp = new System.Windows.Forms.Label();
            this.lblGPUUsage = new System.Windows.Forms.Label();
            this.lblCPUTemp = new System.Windows.Forms.Label();
            this.lblCPUUsage = new System.Windows.Forms.Label();
            this.lblCPUSpeed = new System.Windows.Forms.Label();
            this.lPCName = new System.Windows.Forms.Label();
            this.lRAMTotal = new System.Windows.Forms.Label();
            this.lRAMUsage = new System.Windows.Forms.Label();
            this.lGPUTemp = new System.Windows.Forms.Label();
            this.lGPUUsage = new System.Windows.Forms.Label();
            this.lCPUTemp = new System.Windows.Forms.Label();
            this.lCPUUsage = new System.Windows.Forms.Label();
            this.lCPUSpeed = new System.Windows.Forms.Label();
            this.grbGraph = new System.Windows.Forms.GroupBox();
            this.lRAMUse = new System.Windows.Forms.Label();
            this.prRAMUse = new System.Windows.Forms.ProgressBar();
            this.lUsage = new System.Windows.Forms.Label();
            this.prUsage = new System.Windows.Forms.ProgressBar();
            this.grpSendOptions = new System.Windows.Forms.GroupBox();
            this.trkFrequency = new System.Windows.Forms.TrackBar();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.btnSendData = new System.Windows.Forms.Button();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txUrl = new System.Windows.Forms.TextBox();
            this.ntfSysMon = new System.Windows.Forms.NotifyIcon(this.components);
            this.grbStats.SuspendLayout();
            this.grbGraph.SuspendLayout();
            this.grpSendOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkFrequency)).BeginInit();
            this.SuspendLayout();
            // 
            // grbStats
            // 
            this.grbStats.Controls.Add(this.lblPCName);
            this.grbStats.Controls.Add(this.lblRAMTotal);
            this.grbStats.Controls.Add(this.lblRAMUsage);
            this.grbStats.Controls.Add(this.lblGPUTemp);
            this.grbStats.Controls.Add(this.lblGPUUsage);
            this.grbStats.Controls.Add(this.lblCPUTemp);
            this.grbStats.Controls.Add(this.lblCPUUsage);
            this.grbStats.Controls.Add(this.lblCPUSpeed);
            this.grbStats.Controls.Add(this.lPCName);
            this.grbStats.Controls.Add(this.lRAMTotal);
            this.grbStats.Controls.Add(this.lRAMUsage);
            this.grbStats.Controls.Add(this.lGPUTemp);
            this.grbStats.Controls.Add(this.lGPUUsage);
            this.grbStats.Controls.Add(this.lCPUTemp);
            this.grbStats.Controls.Add(this.lCPUUsage);
            this.grbStats.Controls.Add(this.lCPUSpeed);
            this.grbStats.Location = new System.Drawing.Point(12, 12);
            this.grbStats.Name = "grbStats";
            this.grbStats.Size = new System.Drawing.Size(324, 392);
            this.grbStats.TabIndex = 16;
            this.grbStats.TabStop = false;
            this.grbStats.Text = "System Stats";
            // 
            // lblPCName
            // 
            this.lblPCName.AutoSize = true;
            this.lblPCName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCName.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPCName.Location = new System.Drawing.Point(146, 338);
            this.lblPCName.Name = "lblPCName";
            this.lblPCName.Size = new System.Drawing.Size(31, 30);
            this.lblPCName.TabIndex = 31;
            this.lblPCName.Text = "__";
            // 
            // lblRAMTotal
            // 
            this.lblRAMTotal.AutoSize = true;
            this.lblRAMTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAMTotal.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblRAMTotal.Location = new System.Drawing.Point(146, 292);
            this.lblRAMTotal.Name = "lblRAMTotal";
            this.lblRAMTotal.Size = new System.Drawing.Size(31, 30);
            this.lblRAMTotal.TabIndex = 30;
            this.lblRAMTotal.Text = "__";
            // 
            // lblRAMUsage
            // 
            this.lblRAMUsage.AutoSize = true;
            this.lblRAMUsage.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAMUsage.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblRAMUsage.Location = new System.Drawing.Point(146, 246);
            this.lblRAMUsage.Name = "lblRAMUsage";
            this.lblRAMUsage.Size = new System.Drawing.Size(31, 30);
            this.lblRAMUsage.TabIndex = 29;
            this.lblRAMUsage.Text = "__";
            // 
            // lblGPUTemp
            // 
            this.lblGPUTemp.AutoSize = true;
            this.lblGPUTemp.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUTemp.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblGPUTemp.Location = new System.Drawing.Point(146, 200);
            this.lblGPUTemp.Name = "lblGPUTemp";
            this.lblGPUTemp.Size = new System.Drawing.Size(31, 30);
            this.lblGPUTemp.TabIndex = 28;
            this.lblGPUTemp.Text = "__";
            // 
            // lblGPUUsage
            // 
            this.lblGPUUsage.AutoSize = true;
            this.lblGPUUsage.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUUsage.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblGPUUsage.Location = new System.Drawing.Point(146, 154);
            this.lblGPUUsage.Name = "lblGPUUsage";
            this.lblGPUUsage.Size = new System.Drawing.Size(31, 30);
            this.lblGPUUsage.TabIndex = 27;
            this.lblGPUUsage.Text = "__";
            // 
            // lblCPUTemp
            // 
            this.lblCPUTemp.AutoSize = true;
            this.lblCPUTemp.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUTemp.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblCPUTemp.Location = new System.Drawing.Point(146, 108);
            this.lblCPUTemp.Name = "lblCPUTemp";
            this.lblCPUTemp.Size = new System.Drawing.Size(31, 30);
            this.lblCPUTemp.TabIndex = 26;
            this.lblCPUTemp.Text = "__";
            // 
            // lblCPUUsage
            // 
            this.lblCPUUsage.AutoSize = true;
            this.lblCPUUsage.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUUsage.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblCPUUsage.Location = new System.Drawing.Point(146, 62);
            this.lblCPUUsage.Name = "lblCPUUsage";
            this.lblCPUUsage.Size = new System.Drawing.Size(31, 30);
            this.lblCPUUsage.TabIndex = 25;
            this.lblCPUUsage.Text = "__";
            // 
            // lblCPUSpeed
            // 
            this.lblCPUSpeed.AutoSize = true;
            this.lblCPUSpeed.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUSpeed.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblCPUSpeed.Location = new System.Drawing.Point(146, 16);
            this.lblCPUSpeed.Name = "lblCPUSpeed";
            this.lblCPUSpeed.Size = new System.Drawing.Size(31, 30);
            this.lblCPUSpeed.TabIndex = 24;
            this.lblCPUSpeed.Text = "__";
            // 
            // lPCName
            // 
            this.lPCName.AutoSize = true;
            this.lPCName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPCName.Location = new System.Drawing.Point(6, 338);
            this.lPCName.Name = "lPCName";
            this.lPCName.Size = new System.Drawing.Size(103, 30);
            this.lPCName.TabIndex = 23;
            this.lPCName.Text = "PC Name";
            // 
            // lRAMTotal
            // 
            this.lRAMTotal.AutoSize = true;
            this.lRAMTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRAMTotal.Location = new System.Drawing.Point(6, 292);
            this.lRAMTotal.Name = "lRAMTotal";
            this.lRAMTotal.Size = new System.Drawing.Size(112, 30);
            this.lRAMTotal.TabIndex = 22;
            this.lRAMTotal.Text = "RAM Total";
            // 
            // lRAMUsage
            // 
            this.lRAMUsage.AutoSize = true;
            this.lRAMUsage.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRAMUsage.Location = new System.Drawing.Point(6, 246);
            this.lRAMUsage.Name = "lRAMUsage";
            this.lRAMUsage.Size = new System.Drawing.Size(126, 30);
            this.lRAMUsage.TabIndex = 21;
            this.lRAMUsage.Text = "RAM Usage";
            // 
            // lGPUTemp
            // 
            this.lGPUTemp.AutoSize = true;
            this.lGPUTemp.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGPUTemp.Location = new System.Drawing.Point(6, 200);
            this.lGPUTemp.Name = "lGPUTemp";
            this.lGPUTemp.Size = new System.Drawing.Size(115, 30);
            this.lGPUTemp.TabIndex = 20;
            this.lGPUTemp.Text = "GPU Temp";
            // 
            // lGPUUsage
            // 
            this.lGPUUsage.AutoSize = true;
            this.lGPUUsage.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGPUUsage.Location = new System.Drawing.Point(6, 154);
            this.lGPUUsage.Name = "lGPUUsage";
            this.lGPUUsage.Size = new System.Drawing.Size(121, 30);
            this.lGPUUsage.TabIndex = 19;
            this.lGPUUsage.Text = "GPU Usage";
            // 
            // lCPUTemp
            // 
            this.lCPUTemp.AutoSize = true;
            this.lCPUTemp.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCPUTemp.Location = new System.Drawing.Point(6, 108);
            this.lCPUTemp.Name = "lCPUTemp";
            this.lCPUTemp.Size = new System.Drawing.Size(114, 30);
            this.lCPUTemp.TabIndex = 18;
            this.lCPUTemp.Text = "CPU Temp";
            // 
            // lCPUUsage
            // 
            this.lCPUUsage.AutoSize = true;
            this.lCPUUsage.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCPUUsage.Location = new System.Drawing.Point(6, 62);
            this.lCPUUsage.Name = "lCPUUsage";
            this.lCPUUsage.Size = new System.Drawing.Size(120, 30);
            this.lCPUUsage.TabIndex = 17;
            this.lCPUUsage.Text = "CPU Usage";
            // 
            // lCPUSpeed
            // 
            this.lCPUSpeed.AutoSize = true;
            this.lCPUSpeed.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCPUSpeed.Location = new System.Drawing.Point(6, 16);
            this.lCPUSpeed.Name = "lCPUSpeed";
            this.lCPUSpeed.Size = new System.Drawing.Size(122, 30);
            this.lCPUSpeed.TabIndex = 16;
            this.lCPUSpeed.Text = "CPU Speed";
            // 
            // grbGraph
            // 
            this.grbGraph.Controls.Add(this.lRAMUse);
            this.grbGraph.Controls.Add(this.prRAMUse);
            this.grbGraph.Controls.Add(this.lUsage);
            this.grbGraph.Controls.Add(this.prUsage);
            this.grbGraph.Location = new System.Drawing.Point(351, 9);
            this.grbGraph.Name = "grbGraph";
            this.grbGraph.Size = new System.Drawing.Size(265, 129);
            this.grbGraph.TabIndex = 17;
            this.grbGraph.TabStop = false;
            this.grbGraph.Text = "System Usage";
            // 
            // lRAMUse
            // 
            this.lRAMUse.AutoSize = true;
            this.lRAMUse.Location = new System.Drawing.Point(7, 70);
            this.lRAMUse.Name = "lRAMUse";
            this.lRAMUse.Size = new System.Drawing.Size(53, 13);
            this.lRAMUse.TabIndex = 3;
            this.lRAMUse.Text = "RAM Use";
            // 
            // prRAMUse
            // 
            this.prRAMUse.Location = new System.Drawing.Point(6, 87);
            this.prRAMUse.Name = "prRAMUse";
            this.prRAMUse.Size = new System.Drawing.Size(248, 30);
            this.prRAMUse.TabIndex = 2;
            // 
            // lUsage
            // 
            this.lUsage.AutoSize = true;
            this.lUsage.Location = new System.Drawing.Point(6, 19);
            this.lUsage.Name = "lUsage";
            this.lUsage.Size = new System.Drawing.Size(38, 13);
            this.lUsage.TabIndex = 1;
            this.lUsage.Text = "Usage";
            // 
            // prUsage
            // 
            this.prUsage.Location = new System.Drawing.Point(6, 36);
            this.prUsage.Name = "prUsage";
            this.prUsage.Size = new System.Drawing.Size(248, 30);
            this.prUsage.TabIndex = 0;
            // 
            // grpSendOptions
            // 
            this.grpSendOptions.Controls.Add(this.trkFrequency);
            this.grpSendOptions.Controls.Add(this.lblFrequency);
            this.grpSendOptions.Controls.Add(this.lblState);
            this.grpSendOptions.Controls.Add(this.btnSendData);
            this.grpSendOptions.Controls.Add(this.lblUrl);
            this.grpSendOptions.Controls.Add(this.txUrl);
            this.grpSendOptions.Location = new System.Drawing.Point(351, 144);
            this.grpSendOptions.Name = "grpSendOptions";
            this.grpSendOptions.Size = new System.Drawing.Size(265, 190);
            this.grpSendOptions.TabIndex = 18;
            this.grpSendOptions.TabStop = false;
            this.grpSendOptions.Text = "Send Data";
            // 
            // trkFrequency
            // 
            this.trkFrequency.Location = new System.Drawing.Point(19, 86);
            this.trkFrequency.Maximum = 20;
            this.trkFrequency.Minimum = 1;
            this.trkFrequency.Name = "trkFrequency";
            this.trkFrequency.Size = new System.Drawing.Size(235, 45);
            this.trkFrequency.SmallChange = 5;
            this.trkFrequency.TabIndex = 10;
            this.trkFrequency.Value = 1;
            this.trkFrequency.Scroll += new System.EventHandler(this.trkFrequency_Scroll);
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Location = new System.Drawing.Point(16, 61);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(57, 13);
            this.lblFrequency.TabIndex = 5;
            this.lblFrequency.Text = "Frequency";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(97, 149);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "State";
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(16, 144);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(75, 23);
            this.btnSendData.TabIndex = 2;
            this.btnSendData.Text = "Send";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(16, 19);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(29, 13);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "URL";
            // 
            // txUrl
            // 
            this.txUrl.Location = new System.Drawing.Point(16, 38);
            this.txUrl.Name = "txUrl";
            this.txUrl.Size = new System.Drawing.Size(238, 20);
            this.txUrl.TabIndex = 0;
            // 
            // ntfSysMon
            // 
            this.ntfSysMon.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfSysMon.Icon")));
            this.ntfSysMon.Text = "Sys Mon";
            this.ntfSysMon.Visible = true;
            this.ntfSysMon.DoubleClick += new System.EventHandler(this.ntfSysMon_DoubleClick);
            // 
            // frmSysMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 415);
            this.Controls.Add(this.grpSendOptions);
            this.Controls.Add(this.grbGraph);
            this.Controls.Add(this.grbStats);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSysMon";
            this.Text = "Sys Mon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSysMon_FormClosing);
            this.Load += new System.EventHandler(this.frmSysMon_Load);
            this.Resize += new System.EventHandler(this.frmSysMon_Resize);
            this.grbStats.ResumeLayout(false);
            this.grbStats.PerformLayout();
            this.grbGraph.ResumeLayout(false);
            this.grbGraph.PerformLayout();
            this.grpSendOptions.ResumeLayout(false);
            this.grpSendOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkFrequency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbStats;
        private System.Windows.Forms.Label lblPCName;
        private System.Windows.Forms.Label lblRAMTotal;
        private System.Windows.Forms.Label lblRAMUsage;
        private System.Windows.Forms.Label lblGPUTemp;
        private System.Windows.Forms.Label lblGPUUsage;
        private System.Windows.Forms.Label lblCPUTemp;
        private System.Windows.Forms.Label lblCPUUsage;
        private System.Windows.Forms.Label lblCPUSpeed;
        private System.Windows.Forms.Label lPCName;
        private System.Windows.Forms.Label lRAMTotal;
        private System.Windows.Forms.Label lRAMUsage;
        private System.Windows.Forms.Label lGPUTemp;
        private System.Windows.Forms.Label lGPUUsage;
        private System.Windows.Forms.Label lCPUTemp;
        private System.Windows.Forms.Label lCPUUsage;
        private System.Windows.Forms.Label lCPUSpeed;
        private System.Windows.Forms.GroupBox grbGraph;
        private System.Windows.Forms.Label lRAMUse;
        private System.Windows.Forms.ProgressBar prRAMUse;
        private System.Windows.Forms.Label lUsage;
        private System.Windows.Forms.ProgressBar prUsage;
        private System.Windows.Forms.GroupBox grpSendOptions;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txUrl;
        private System.Windows.Forms.TrackBar trkFrequency;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.NotifyIcon ntfSysMon;
    }
}

