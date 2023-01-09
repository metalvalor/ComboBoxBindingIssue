using System;

namespace Shared
{
    public class ExpenseCategory : BindingBase
    {
        public Guid Id { get; set; }
        public String Name { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is ExpenseCategory result &&
                   Id == result.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(ExpenseCategory x, ExpenseCategory y)
        {
            return x?.Id == y?.Id;
        }

        public static bool operator !=(ExpenseCategory x, ExpenseCategory y)
        {
            return !(x?.Id == y?.Id);
        }

    }
}
