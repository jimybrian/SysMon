using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SystemMonNETCore.Models;

namespace SystemMonNETCore.Repository
{
    public class SystemMonitorRepo
    {
        Connection wmiConnection;
        OpenHardwareMonitor wmiOpenHMon;

        public SystemMonitorRepo()
        {
            wmiConnection = new Connection();
            wmiOpenHMon = new OpenHardwareMonitor(wmiConnection);
        }


        public SysInfoItem GetSystemInfo()
        {
            var hardwareNfo = wmiOpenHMon.GetHardwareListProperties();
            var sensorNfo = wmiOpenHMon.GetSensorListProperties();

            var cpuSensorData = sensorNfo.Where(s => s.Name == OpenHardwareTypes.CPUTotal || s.Name == OpenHardwareTypes.CPUPackage);
            var gpuData = sensorNfo.Where(s => s.Name == OpenHardwareTypes.GPUCore);
            var gpuName = hardwareNfo.FirstOrDefault(h => h.HardwareType == OpenHardwareTypes.GPU_NAME);
            var cpuName = hardwareNfo.FirstOrDefault(h => h.HardwareType == OpenHardwareTypes.CPU_NAME);
            var ramUsage = sensorNfo.FirstOrDefault(c => c.Name == OpenHardwareTypes.UsedMemory && c.SensorType == OpenHardwareTypes.Data).Value;
            var ramFree = sensorNfo.FirstOrDefault(c => c.Name == OpenHardwareTypes.AvailableMemory && c.SensorType == OpenHardwareTypes.Data).Value;
            var ramTotal = ((float.Parse(ramUsage)) + (float.Parse(ramFree))).ToString();
            var ramLoad = sensorNfo.FirstOrDefault(c => c.Name == OpenHardwareTypes.Memory && c.SensorType == OpenHardwareTypes.Load).Value;
            //var cpuClock = sensorNfo.Where(c => c.Name != OpenHardwareTypes.GPUCore && c.SensorType == OpenHardwareTypes.Clock).OrderBy(c => c.Index).FirstOrDefault().Value;

            var cpuClock = (from s in sensorNfo
                            where s.Name.Contains("CPU") && s.SensorType == OpenHardwareTypes.Clock
                            orderby s.Index
                            select new { s }).FirstOrDefault();

            return new SysInfoItem()
            {
                cpuClock = cpuClock.s.Max,
                cpuName = cpuName.Name,
                cpuTempMax = cpuSensorData.FirstOrDefault(s => s.Name == OpenHardwareTypes.CPUPackage && s.SensorType == OpenHardwareTypes.Temperature).Max,
                cpuTempVal = cpuSensorData.FirstOrDefault(s => s.Name == OpenHardwareTypes.CPUPackage && s.SensorType == OpenHardwareTypes.Temperature).Value,
                cpuUsageMax = cpuSensorData.FirstOrDefault(c => c.Name == OpenHardwareTypes.CPUTotal && c.SensorType == OpenHardwareTypes.Load).Max,
                cpuUsageVal = cpuSensorData.FirstOrDefault(c => c.Name == OpenHardwareTypes.CPUTotal && c.SensorType == OpenHardwareTypes.Load).Value,
                gpuName = gpuName.Name,
                gpuTempMax = gpuData.FirstOrDefault(c => c.Name == OpenHardwareTypes.GPUCore && c.SensorType == OpenHardwareTypes.Temperature).Max,
                gpuTempVal = gpuData.FirstOrDefault(c => c.Name == OpenHardwareTypes.GPUCore && c.SensorType == OpenHardwareTypes.Temperature).Value,
                gpuUsageMax = gpuData.FirstOrDefault(c => c.Name == OpenHardwareTypes.GPUCore && c.SensorType == OpenHardwareTypes.Load).Max,
                gpuUsageVal = gpuData.FirstOrDefault(c => c.Name == OpenHardwareTypes.GPUCore && c.SensorType == OpenHardwareTypes.Load).Value,
                pcName = Environment.MachineName,
                ramFree = ramFree,
                ramUsage = ramUsage,
                ramLoad = ramLoad,
                ramTotal = ramTotal
            };
        }


    }
}