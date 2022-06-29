using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysMonitorGUI.SysMon.WMIObjects
{
    class OpenHardwareTypes
    {
        //sensor name
        public static string CPUCores = "CPU Cores";
        public static string GPUMemory_Total = "GPU Memory Total";
        public static string CPUPackage = "CPU Package";
        public static string CPUTotal = "CPU Total";
        public static string GPUCore = "GPU Core";
        public static string GPUMemory = "GPU Memory";
        public static string UsedMemory = "Used Memory";
        public static string AvailableMemory = "Available Memory";
        public static string Memory = "Memory";
        public static string GPU_NAME = "GpuNvidia";
        public static string CPU_NAME = "CPU";
        public static string BusSpeed = "Bus Speed";

        //sensor type
        public static string Temperature = "Temperature";
        public static string Power = "Power";
        public static string Load = "Load";
        public static string Clock = "Clock";
        public static string Throughput = "Throughput";
        public static string Data = "Data";
        public static string SmallData = "SmallData";
    }

    public class SensorTypeObject
    {
        public string Identifier { get; set; }
        public string Index { get; set; }
        public string InstanceId { get; set; }
        public string Max { get; set; }
        public string Min { get; set; }
        public string Name { get; set; }
        public string Parent { get; set; }
        public string ProcessId { get; set; }
        public string SensorType { get; set; }
        public string Value { get; set; }
    }

    public class HardwareTypeObject
    {
        public string Identifier { get; set; }
        public string Name { get; set; }
        public string Parent { get; set; }
        public string HardwareType { get; set; }
    }


    public class SysInfoItem
    {
        public string cpuClock { get; set; }
        public string cpuName { get; set; }
        public string gpuName { get; set; }
        public string cpuUsageVal { get; set; }
        public string cpuUsageMax { get; set; }
        public string cpuTempVal { get; set; }
        public string cpuTempMax { get; set; }
        public string gpuUsageVal { get; set; }
        public string gpuUsageMax { get; set; }
        public string gpuTempVal { get; set; }
        public string gpuTempMax { get; set; }
        public string ramUsage { get; set; }
        public string ramFree { get; set; }
        public string ramLoad { get; set; }
        public string ramTotal { get; set; }
        public string pcName { get; set; }
    }
}
