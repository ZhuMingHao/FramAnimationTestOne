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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FramAnimationTestOne
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Storyboard storyboard;
        public MainPage()
        {
            this.InitializeComponent();

            storyboard = new Storyboard();
            var animation = new ObjectAnimationUsingKeyFrames();
            animation.RepeatBehavior = RepeatBehavior.Forever;
          
            animation.SpeedRatio = 2;
            for (int i = 0; i < 14; i++)
            {
                var key = new BitmapImage(new Uri($"ms-appx:///Assets/{i+1}.png"));
                animation.KeyFrames.Add(new DiscreteObjectKeyFrame() { KeyTime = TimeSpan.FromSeconds(i*0.1), Value =  key });
            
            }
            
            Storyboard.SetTarget(animation, image1);
            Storyboard.SetTargetProperty(animation, "Source");

            storyboard.Children.Add(animation);
           

        }

        private void Image1_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private bool flag;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            flag = !flag;
            if (flag)
            {
                std2.Begin();
            }
            else
            {
                std2.Stop();
            }
           
        }
    }
}
