using System;

using UWPTemplateMVVMLight.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UWPTemplateMVVMLight.Views
{
    public sealed partial class WebViewPage : Page
    {
        private WebViewViewModel ViewModel
        {
            get { return ViewModelLocator.Current.WebViewViewModel; }
        }

        public WebViewPage()
        {
            InitializeComponent();
            ViewModel.Initialize(webView);
        }
    }
}
