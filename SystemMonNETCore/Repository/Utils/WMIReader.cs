using SystemMonNETCore.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Web;
using Newtonsoft.Json;

namespace SystemMonNETCore.Repository.Utils
{
    class WMIReader
    {      
        public static T CreateFromDictionary<T>(IReadOnlyDictionary<string, string> d) where T : new()
        {
            T obj = new T();

            foreach (var propertyInfo in typeof(T).GetProperties())
            {
                propertyInfo.SetValue(obj, d[propertyInfo.Name]);
            }

            return obj;
        }

        public static List<HardwareTypeObject> GetHardwareProperties(Connection WMIConnection, string SelectQuery)
        {
            ManagementScope connectionScope = WMIConnection.GetConnectionScope;
            SelectQuery msQuery = new SelectQuery(SelectQuery);
            ManagementObjectSearcher searchProcedure = new ManagementObjectSearcher(connectionScope, msQuery);
            List<HardwareTypeObject> keyProperties = new List<HardwareTypeObject>();

            try
            {
                foreach (ManagementObject item in searchProcedure.Get())
                {
                    var sensorProp = new Dictionary<string, string>();
                    foreach (var prop in item.Properties)
                    {
                        sensorProp.Add(prop.Name, prop.Value.ToString());
                    };



                    keyProperties.Add(CreateFromDictionary<HardwareTypeObject>(sensorProp));
                }
            }
            catch (ManagementException e)
            {
                /* Do Nothing */
            }


            return keyProperties;
        }


        public static List<SensorTypeObject> GetSensorProperties(Connection WMIConnection, string SelectQuery)
        {
            ManagementScope connectionScope = WMIConnection.GetConnectionScope;
            SelectQuery msQuery = new SelectQuery(SelectQuery);
            ManagementObjectSearcher searchProcedure = new ManagementObjectSearcher(connectionScope, msQuery);
            List<SensorTypeObject> keyProperties = new List<SensorTypeObject>();

            try
            {
                foreach (ManagementObject item in searchProcedure.Get())
                {
                    var sensorProp = new Dictionary<string, string>();
                    foreach (var prop in item.Properties)
                    {
                        sensorProp.Add(prop.Name, prop.Value.ToString());
                    };



                    keyProperties.Add(CreateFromDictionary<SensorTypeObject>(sensorProp));
                }
            }
            catch (ManagementException e)
            {
                /* Do Nothing */
            }

            Debug.WriteLine(JsonConvert.SerializeObject(keyProperties));

            return keyProperties;
        }
    }
}