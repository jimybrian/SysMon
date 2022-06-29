using SysMonitorGUI.SysMon.WMIObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysMonitorGUI.Wmi
{
    class OpenHardwareMonitor
    {
        Connection WMIConnection;

        public OpenHardwareMonitor(Connection WMIConnection)
        {
            this.WMIConnection = WMIConnection;
        }

        public List<HardwareTypeObject> GetHardwareListProperties()
        {
            return WMIReader.GetHardwareProperties(WMIConnection,
                                              "SELECT * FROM Hardware");
        }

        public List<SensorTypeObject> GetSensorListProperties()
        {
            return WMIReader.GetSensorProperties(WMIConnection,
                                               "SELECT * FROM Sensor");
        }
    }
}
