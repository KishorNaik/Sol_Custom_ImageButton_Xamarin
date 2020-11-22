using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sol_Demo.ViewModels
{
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            OnCommand = new Command((name) => this.OnCommandDemo(name));
        }

        public ICommand OnCommand { get; }

        private void OnCommandDemo(object name)
        {
        }
    }
}