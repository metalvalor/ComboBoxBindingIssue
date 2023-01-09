using System;

namespace Shared
{
    public class Expense : BindingBase
    {
		private String _Name;
		public String Name
		{
			get { return _Name; }
			set
			{
				_Name = value;
				RaisePropertyChanged(nameof(Name));
			}
		}

		private ExpenseCategory _Category;
		public ExpenseCategory Category
		{
			get { return _Category; }
			set
			{
				_Category = value;
				RaisePropertyChanged(nameof(Category));
			}
		}
	}

	public class ExpenseSpecial : Expense
	{

	}
}
