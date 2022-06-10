using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CommunityToolkit.Mvvm.Input;

namespace WpfApp1
{
    public partial class BaseViewModel
    {
        [RelayCommand]
        public virtual void TestMethod()
        {
            MessageBox.Show("Hello from the Base VM");
        }
    }
}
