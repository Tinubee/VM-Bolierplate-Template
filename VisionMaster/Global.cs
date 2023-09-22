using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisionMaster.Schemas;

namespace VisionMaster
{
    public static class Global
    {
        public static MainForm MainForm = null;
        public static VMControl VMControl;
        public static Setting Setting;

        public static Boolean Init()
        {
            Setting = new Setting();
            VMControl = new VMControl();

            Setting.Init();
            VMControl.Init();

            return true;
        }
    }
}
