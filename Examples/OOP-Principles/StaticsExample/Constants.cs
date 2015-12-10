using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticsExample
{
    class Constants
    {
        public static string myString = ConfigurationSettings.AppSettings["myString"];
    }
}
