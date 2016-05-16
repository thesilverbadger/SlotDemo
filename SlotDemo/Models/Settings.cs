using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SlotDemo.Models
{
    public static class Settings
    {
        private static string _version;

        public static void Init()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            _version = fvi.FileVersion;
        }

        public static string Version => _version;
    }
}
