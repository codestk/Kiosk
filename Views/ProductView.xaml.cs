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
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
            this.Frame.Navigate(typeof(MainMenu));
        }

  

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

         
    }
}
