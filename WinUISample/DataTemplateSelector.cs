using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Shared;


namespace Selectors
{
    public class TemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate SelectTemplateCore(object item) => SelectTemplateCore(item, null);

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            if (item == null) return null;
            return Application.Current.Resources[item is ExpenseSpecial ? "DTExpenseSpecial" : "DTExpense"] as DataTemplate;
        }
    }
}