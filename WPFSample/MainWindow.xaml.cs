using Shared;
using System.Windows;

namespace WPFSample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = ExpensesContainer.Mock();
        }
    }
}
