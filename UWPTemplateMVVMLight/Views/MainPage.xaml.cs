using System;

using UWPTemplateMVVMLight.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UWPTemplateMVVMLight.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel
        {
            get { return ViewModelLocator.Current.MainViewModel; }
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
