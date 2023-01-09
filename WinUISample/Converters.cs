using System;
using System.Linq;
using System.Globalization;
using Shared;
using Microsoft.UI.Xaml.Data;

namespace Converters
{
    public class ExpenseCategoryListConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, string culture)
        {
            return ExpensesContainer.Categories.ToList();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string culture)
        {
            throw new NotImplementedException();
        }
    }

}
