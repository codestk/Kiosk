using Microsoft.ProjectOxford.Vision.Contract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace IntelligentKioskSample.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProductView : Page
    {
        private Storyboard rotation = new Storyboard();
        public ProductView()
        {
            this.InitializeComponent();
            //DoubleAnimation animation = new DoubleAnimation();
            //animation.From = 0.0;
            //animation.To = 360.0;
            //animation.BeginTime = TimeSpan.FromSeconds(1);
            //animation.RepeatBehavior = RepeatBehavior.Forever;
            //Storyboard.SetTarget(animation, Display);
            //Storyboard.SetTargetProperty(animation, "(UIElement.Projection).(PlaneProjection.Rotation" + "Y" + ")");
            //rotation.Children.Clear();
            //rotation.Children.Add(animation);
            //rotation.Begin();
            myStoryboard.Begin();

            //bgleft.Source = new SvgImageSource(new Uri("http://thenewcode.com/assets/images/thumbnails/homer-simpson.svg", UriKind.Absolute));
            EnterKioskMode();


          
         
        }

        private void EnterKioskMode()
        {
            ApplicationView view = ApplicationView.GetForCurrentView();
            if (!view.IsFullScreenMode)
            {
                view.TryEnterFullScreenMode();
                

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainMenu));
        }

  

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {



            this.Frame.Navigate(typeof(MasterDetailSelection));

        }

       
    }
}
