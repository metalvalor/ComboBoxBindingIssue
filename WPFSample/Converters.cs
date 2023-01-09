using System;
using System.Linq;
using System.Windows.Data;
using System.Globalization;
using Shared;

namespace Converters
{
    public class ExpenseCategoryListConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ExpensesContainer.Categories.ToList();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
