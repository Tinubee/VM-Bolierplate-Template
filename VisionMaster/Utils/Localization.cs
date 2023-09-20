using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;


namespace VisionMaster.Utils
{
    public class Localization
    {
        public static TranslationAttribute Title = new TranslationAttribute("LGES VDA590 TPA Total Inspection");
        public static TranslationAttribute Cancel = new TranslationAttribute("Cancel", "취소", "Zrušiť");
        public static TranslationAttribute Close = new TranslationAttribute("Close", "닫기", "Zavrieť");
        public static TranslationAttribute Save = new TranslationAttribute("Save", "저장", "Uložiť");
        public static TranslationAttribute Delete = new TranslationAttribute("Delete", "삭제", "Odstrániť");
        public static TranslationAttribute Confirm = new TranslationAttribute("Confirm", "확인", "Potvrďte");
        public static TranslationAttribute Infomation = new TranslationAttribute("Infomation", "정보", "Informácie");
        public static TranslationAttribute Warning = new TranslationAttribute("Warning", "경고", "POZOR");
        public static TranslationAttribute Error = new TranslationAttribute("Error", "오류", "Chyba");
        public static TranslationAttribute Search = new TranslationAttribute("Search", "조회", "Vyhľadávanie");
        public static TranslationAttribute Day = new TranslationAttribute("Day", "일자", "Deň");
        public static TranslationAttribute Time = new TranslationAttribute("Time", "시간", "Čas");

        public static Language CurrentLanguage { get; set; } //{ get { return (Language)Properties.Settings.Default.Language; } }

        public static void SetCulture()
        {
            if (CurrentLanguage == Language.KO)
                CultureInfo.CurrentCulture = new CultureInfo("ko-KR", false);
            else if (CurrentLanguage == Language.SK)
                CultureInfo.CurrentCulture = new CultureInfo("sk-SK", false);
            else
                CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
        }

        public static String GetString(PropertyInfo prop) { return GetString(prop, CurrentLanguage); }
        public static String GetString(PropertyInfo prop, Language lang)
        {
            TranslationAttribute a = GetAttribute<TranslationAttribute>(prop);
            if (a == null) return prop.Name;
            return a.GetString(lang);
        }
        public static String GetString(Enum num) { return GetString(num, CurrentLanguage); }
        public static String GetString(Enum num, Language lang)
        {
            TranslationAttribute a = GetAttribute<TranslationAttribute>(num);
            if (a == null) return num.ToString();
            return a.GetString(lang);
        }
        public static T GetAttribute<T>(PropertyInfo property)
        {
            if (property == null) return default(T);
            return (T)property.GetCustomAttributes(typeof(T), true).FirstOrDefault();
        }
        public static T GetAttribute<T>(Enum @enum)
        {
            Type type = @enum.GetType();
            return (T)type.GetField(type.GetEnumName(@enum)).GetCustomAttributes(typeof(T), true).FirstOrDefault();
        }
    }

    public enum Language
    {
        [Description("English")]
        EN = 0,
        [Description("한국어")]
        KO = 1,
        [Description("Slovenská")]
        SK = 2
    }

    public class TranslationAttribute : Attribute
    {
        public String KO = String.Empty;
        public String EN = String.Empty;
        public String SK = String.Empty;

        public TranslationAttribute() { }

        public TranslationAttribute(String en)
        {
            this.EN = en;
            this.KO = en;
            this.SK = en;
        }

        public TranslationAttribute(String en, String ko)
        {
            this.EN = en;
            this.KO = ko;
            this.SK = en;
        }

        public TranslationAttribute(String en, String ko, String sk)
        {
            this.EN = en;
            this.KO = ko;
            this.SK = sk;
        }

        public String GetString(Language lang)
        {
            if (lang == Language.EN) return this.EN;
            if (lang == Language.KO) return this.KO;
            if (lang == Language.SK) return this.SK;
            return this.EN;
        }

        public String GetString() { return GetString(Localization.CurrentLanguage); }
    }
}
