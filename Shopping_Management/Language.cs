using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Resources;

namespace Shopping_Management
{
    class Language
    {
        static ResourceManager rm = new ResourceManager("Shopping_Management.resources.lang.Language", typeof(frmDashboard).Assembly);
        static CultureInfo culture_en_US = CultureInfo.CreateSpecificCulture("en-US") ;
        static CultureInfo culture_vi_VN = CultureInfo.CreateSpecificCulture("vi-VN");
        public static string GetStringMessage(bool english, string key)
        {
            if (english)
            {
                return rm.GetString(key, culture_en_US);
            }
            return rm.GetString(key, culture_vi_VN);
        }
    }
}
