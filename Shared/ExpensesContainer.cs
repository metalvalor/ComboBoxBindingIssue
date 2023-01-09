using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Shared
{
    public class ExpensesContainer : BindingBase
    {
        private ObservableCollection<Expense> _Expenses;
        public ObservableCollection<Expense> Expenses
        {
            get { return _Expenses; }
            set
            {
                _Expenses = value;
                RaisePropertyChanged(nameof(Expenses));
            }
        }

        public static ExpensesContainer Mock()
        {
            return new ExpensesContainer
            {
                Expenses = new ObservableCollection<Expense> {
                    new Expense{Category = Categories[0],Name="Expense 1" },
                    new Expense{Category = Categories[1],Name="Expense 2" },
                    new Expense{Category = Categories[1],Name="Expense 3" },
                    new Expense{Category = Categories[0],Name="Expense 4" },
                    new ExpenseSpecial{Category = Categories[1], Name="Expense special"  },
                },
            };
        }

        public static List<ExpenseCategory> Categories = new List<ExpenseCategory>
        {
            new ExpenseCategory{
                Id = new System.Guid("ACDB02FF-7F9F-4B6D-9315-1026C3BA58D1"),
                Name = "Category A"
            },  new ExpenseCategory{
                Id = new System.Guid("8FD2B5C5-C2A5-4BD1-A54B-0BEE55E21E8F"),
                Name = "Category B"
            }
        };
    }
}
