using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Walkthrough
{
    public static class AppConfigReader
    {
        public static readonly string SigninPageUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string InventoryPageUrl = ConfigurationManager.AppSettings["inventory_url"];
    }
}
