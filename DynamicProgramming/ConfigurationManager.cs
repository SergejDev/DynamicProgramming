using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    static class ConfigurationManager
    {
        private static AppSettingsReader settingsReader = new AppSettingsReader();

        public static int GetWeeksCount()
        {
            return (int)settingsReader.GetValue("weeksCount", typeof(int));
        }
    }
}
