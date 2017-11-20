using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Graphics.Display;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            theCanvas.Height = DisplayInformation.GetForCurrentView().ScreenHeightInRawPixels;
            theCanvas.Width = DisplayInformation.GetForCurrentView().ScreenWidthInRawPixels;
        }

        private void theCanvas_Loaded(object sender, RoutedEventArgs e)
        {
            var button = new Button();
            button.Content = "Button";
            button.Width = 200;
            button.Height = 100;
            theCanvas.Children.Add(button);
            Canvas.SetTop(button, theCanvas.ActualHeight / 2);
            Canvas.SetLeft(button, theCanvas.ActualWidth / 2);
        }
    }
}
