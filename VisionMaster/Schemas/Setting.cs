using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MvUtils;

namespace VisionMaster.Schemas
{
    public class Setting
    {
        [Translation("Config Path", "설정 저장 경로"), JsonProperty("ConfigSavePath")]
        public String DefaultPath { get; set; } = @"C:\VMBolierplateTemplate\Config";

        private String SvaeFile { get { return Path.Combine(this.DefaultPath, "Config.json"); } }
        public Boolean Init()
        {
            return this.Load();
        }

        public Boolean Load()
        {
            if (File.Exists(SvaeFile))
            {
                try
                {
                    Setting Set = JsonConvert.DeserializeObject<Setting>(File.ReadAllText(SvaeFile, Encoding.UTF8));
                    foreach (PropertyInfo p in Set.GetType().GetProperties())
                    {
                        if (!p.CanWrite) continue;
                        Object v = p.GetValue(Set);
                        if (v == null) continue;
                        p.SetValue(this, v);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            else
            {
                this.Save();
            }

            return true;
        }

        public void Save()
        {
            if (!MvUtils.Utils.WriteAllText(SvaeFile, JsonConvert.SerializeObject(this, MvUtils.Utils.JsonSetting())))
            {
                Debug.WriteLine("Failed To Save Setting File.");
            }
        }
    }
}
