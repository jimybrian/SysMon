using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysMonitorGUI.Extensions
{
    public static class StringExtensions
    {  
        public static string roundUp(this string value)
        {
            var endVal = value;

            try
            {
                var numVal = Math.Round(float.Parse(value));
                endVal = numVal.ToString();
            }catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return endVal;
        }
    }
}
