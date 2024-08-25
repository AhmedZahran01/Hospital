using Hospital;
using Hospital.DataObjects;
using System;
using System.Windows;
using System.Windows.Media.Media3D;

namespace Hospital.Utils
{
    public class AppTheme
    {
        public static string CurrentTheme;

        private static void ChangeTheme(Uri themeuri)
        {
            ResourceDictionary Theme = new ResourceDictionary() { Source = themeuri };

            App.Current.Resources.Clear();
            App.Current.Resources.MergedDictionaries.Add(Theme);
        }

        public static void ChangeThemeToLight()
		{
			AppTheme.ChangeTheme(new Uri("Theme/LightTheme.xaml", UriKind.Relative));
            CurrentTheme = "Light";
		}

        public static void ChangeThemeToDark()
		{
			AppTheme.ChangeTheme(new Uri("Theme/DarkTheme.xaml", UriKind.Relative));
            CurrentTheme = "Dark";
        }

        public static void ChangeThemeToGreen()
		{
			AppTheme.ChangeTheme(new Uri("Theme/GreenTheme.xaml", UriKind.Relative));
            CurrentTheme = "Green";
        }
        public static void ChangeThemeToBlue()
        {
            AppTheme.ChangeTheme(new Uri("Theme/BlueTheme.xaml", UriKind.Relative));
            CurrentTheme = "Blue";
        }

        public static void SwitchTheme(string theme)
        {
            switch (theme)
            {
                case "Light":
                    AppTheme.ChangeThemeToLight();
                    break;
                case "Dark":
                    AppTheme.ChangeThemeToDark();
                    break;
                case "Green":
                    AppTheme.ChangeThemeToGreen();
                    break;

                case "Blue":
                    AppTheme.ChangeThemeToBlue();
                    break;

                default:
                    throw new InvalidOperationException("Invalid theme");
            }
          
            #region Comment theme Dictionary Region
            //{
            //    var themeDictionary = new ResourceDictionary();
            //    switch (theme)
            //    {
            //        case "Light":
            //            themeDictionary.Source = new Uri("Theme/LightTheme.xaml", UriKind.Relative);
            //            break;
            //        case "Dark":
            //            themeDictionary.Source = new Uri("Theme/DarkTheme.xaml", UriKind.Relative);
            //            break;
            //        case "Green":
            //            themeDictionary.Source = new Uri("Theme/GreenTheme.xaml", UriKind.Relative);
            //            break;
            //        case "Blue":
            //            themeDictionary.Source = new Uri("Theme/BlueTheme.xaml", UriKind.Relative);
            //            break;
            //        default:
            //            throw new ArgumentException("Unknown theme", nameof(theme));
            //    }

            //    Clear existing dictionaries and add new theme
            //    Application.Current.Resources.MergedDictionaries.Clear();
            //    Application.Current.Resources.MergedDictionaries.Add(themeDictionary);

            #endregion
        
        
        }
    }
}
