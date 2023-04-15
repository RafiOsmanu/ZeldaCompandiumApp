using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace ZeldaCompandiumApp.Converters
{
    internal class StringToImage : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string type = value as string;
            if (!string.IsNullOrEmpty(type))
            {
                if(type == "None" ||  type == " ")
                {
                    return null;
                }
                string imageName = $"{type}.png";
                string imagePath = $"pack://application:,,,/{Assembly.GetExecutingAssembly().GetName().Name};component/Resources/Materials/{imageName}";

                return new BitmapImage(new Uri(imagePath, UriKind.Absolute));
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
