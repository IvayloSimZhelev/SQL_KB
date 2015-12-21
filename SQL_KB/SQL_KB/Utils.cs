using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace SQL_KB
{
    class Utils
    {
      
        #region Config
        public static void ConfigSet(string name, string value)
        {
            string applicationName = Environment.GetCommandLineArgs()[0];
            Configuration config = ConfigurationManager.OpenExeConfiguration(applicationName);

            if (config.AppSettings.Settings[name] == null)
                config.AppSettings.Settings.Add(name, value);
            config.AppSettings.Settings[name].Value = value;
            config.Save(ConfigurationSaveMode.Modified);
        }

        public static void ConfigRemove(string name)
        {
            string applicationName = Environment.GetCommandLineArgs()[0];
            Configuration config = ConfigurationManager.OpenExeConfiguration(applicationName);

            if (config.AppSettings.Settings[name] != null)
            {
                config.AppSettings.Settings.Remove(name);
                config.Save(ConfigurationSaveMode.Modified);
            }
        }

        public static string ConfigGet(string name)
        {
            string applicationName = Environment.GetCommandLineArgs()[0];
            Configuration config = ConfigurationManager.OpenExeConfiguration(applicationName);

            string sss = String.Empty;
            if (config.AppSettings.Settings[name] != null)
                sss = config.AppSettings.Settings[name].Value;

            return sss;
        }

        public static AutoCompleteStringCollection GetAutoComplSQLs()
        {
            var source = new AutoCompleteStringCollection();
            string[] sss = { "" };
            int sssIndex = 0;

            string applicationName = Environment.GetCommandLineArgs()[0];
            Configuration config = ConfigurationManager.OpenExeConfiguration(applicationName);

            foreach (KeyValueConfigurationElement item in config.AppSettings.Settings)
            {
                if (item.Key.IndexOf("SQLs") == 0)
                {
                    if (sssIndex > sss.GetUpperBound(0))
                        Array.Resize(ref sss, sssIndex + 1);
                    sss[sssIndex] = item.Value.ToString();
                    sssIndex++;
                }
            }
            source.AddRange(sss);
            return source;

        }

        public static string ConfigFindByVal(string nameMatch, string val)
        {
            //Search the key name by its prefix and full match the value
            string ret = String.Empty;
            string applicationName = Environment.GetCommandLineArgs()[0];
            Configuration config = ConfigurationManager.OpenExeConfiguration(applicationName);

            foreach (KeyValueConfigurationElement item in config.AppSettings.Settings)
            {
                if ((item.Key.IndexOf(nameMatch) == 0) && (item.Value.ToString() == val))
                {
                    ret = item.Key.ToString();
                }
            }

            return ret;
        }


        #endregion

        public static void recolorListItems(ListView lv)
        {
            for (int ix = 0; ix < lv.Items.Count; ++ix)
            {
                var item = lv.Items[ix];
                item.BackColor = (ix % 2 == 0) ? Color.WhiteSmoke : Color.White;
            }
        }

    }
}
