﻿using System;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace IntelligentKioskSample.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainMenu : Page
    {


        private string img0 = "RealTime.PNG";       //Menu 1
        private string img1 = "RealTime.PNG";       //Menu 2
        private string img2 = "StoreLogo.png";      //Menu 3
        private string img3 = "squaretile-sdk.png"; //Animation

        public MainMenu()
        {
            this.InitializeComponent();

            EnterKioskMode();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            SetAnimtionImage(img1);
            //ConnectedAnimationService.GetForCurrentView().PrepareToAnimate("cat", Cat);
            //await Task.Delay(TimeSpan.FromSeconds(2));
            //await new Windows.UI.Popups.MessageDialog("Hello World").ShowAsync();

           // this.Frame.Navigate(typeof(_1ScreenServer));
            this.Frame.Navigate(typeof(_1ScreenServer), null, new EntranceNavigationTransitionInfo());

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SetAnimtionImage(img2);
            this.Frame.Navigate(typeof(GameView));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SetAnimtionImage(img3);

            this.Frame.Navigate(typeof(ProductView));
        }

        private void SetAnimtionImage(string image)
        {
            BitmapImage bitmapImage = new BitmapImage();

            bitmapImage.UriSource = new Uri("ms-appx:///Assets/" + image);

            capturedPhoto.Source = bitmapImage;

        }

        private void Image_Loaded(object sender, RoutedEventArgs e)
        {
            SetAnimtionImage(img0);
        }

        private void EnterKioskMode()
        {
            ApplicationView view = ApplicationView.GetForCurrentView();
            if (!view.IsFullScreenMode)
            {
                view.TryEnterFullScreenMode();
            }
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            EnterKioskMode();

            //if (string.IsNullOrEmpty(SettingsHelper.Instance.TextAnalyticsKey))
            //{
            //    await new MessageDialog("Missing Text Analytics Key. Please enter the key in the Settings page.", "Missing API Key").ShowAsync();
            //}

            base.OnNavigatedTo(e);
        }

        public async System.Threading.Tasks.Task Start()
        {
            await new MessageDialog(" sytrtr", "yrtrr").ShowAsync();
        }
    }
}