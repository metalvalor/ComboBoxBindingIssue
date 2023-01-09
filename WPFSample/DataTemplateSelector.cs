using Shared;
using System.Windows;
using System.Windows.Controls;

namespace Selectors
{
    public class TemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item == null) return null;
            return Application.Current.Resources[item is ExpenseSpecial ? "DTExpenseSpecial" : "DTExpense"] as DataTemplate;
        }
    }
}