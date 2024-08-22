using System.Resources;
using System.Reflection;
using System.Globalization;
using System;
using System.Windows;

namespace Hospital.Utils
{
    public static class LangHelper
    {
        private static ResourceDictionary ResourceDictionary = new ResourceDictionary();
        public static string CurrentLanguage;

        public static event EventHandler LanguageChanged;

        private static void OnLanguageChanged()
        {
            LanguageChanged?.Invoke(null, EventArgs.Empty);
        }

        #region Comment Get String Region
        //public static string GetString(string name)
        //{
        //    foreach (ResourceDictionary dictionary in Application.Current.Resources.MergedDictionaries)
        //    {
        //        if (dictionary.Contains(name))
        //        {
        //            return dictionary[name] as string;
        //        }
        //    }
        //    throw new InvalidOperationException("Invalid key or theme not found");
        //} 
        #endregion

        public static string GetString(string name) //LightTheme DarkTheme GreenTheme
        {
            if (ResourceDictionary.Contains(name))
            {
                return ResourceDictionary[name] as string;
            }
            throw new InvalidOperationException("Invalid key");
        }

        public static void SwitchLanguage(string language)
        {
            switch (language)
            {
                case "AR":
                case "ar":
                    ResourceDictionary.Source = new Uri("../Language/Strings.ar.xaml", UriKind.Relative);
                    CurrentLanguage = "ar";
                    break;
              
                case "EN":
                case "en":
                    ResourceDictionary.Source = new Uri("../Language/Strings.en.xaml", UriKind.Relative);
                    CurrentLanguage = "en";
                    break;


                case "FR":
                case "fr":
                    ResourceDictionary.Source = new Uri("../Language/Strings.FR.xaml", UriKind.Relative);
                    CurrentLanguage = "Fr";
                    break;
                default:
                    throw new InvalidOperationException("Invalid language");
            }
            OnLanguageChanged();
        }

        public static ResourceDictionary GetResourceDictionary()
        {
            return ResourceDictionary;
        }
    }
}