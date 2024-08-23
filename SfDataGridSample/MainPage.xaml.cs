using System.ComponentModel;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            
        }

        private void Entry_HandlerChanged(object sender, EventArgs e)
        {
#if WINDOWS
            if (sender is Entry entry && entry.Handler?.PlatformView is Microsoft.Maui.Platform.MauiPasswordTextBox textBox)
            {
                textBox.KeyDown += TextBox_KeyDown;
            }
#endif
        }

#if WINDOWS 
        private void TextBox_KeyDown(object sender, Microsoft.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Tab) 
            {
                DisplayAlert("Tab Pressed", "The Tab key was pressed", "OK");
            }

        }
#endif
    }

}
