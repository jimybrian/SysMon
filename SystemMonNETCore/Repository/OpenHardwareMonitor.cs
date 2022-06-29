using SystemMonNETCore.Models;
using SystemMonNETCore.Repository.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystemMonNETCore.Repository
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