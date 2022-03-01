using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Color_Generator.Controls
{
    public class Modal : ContentControl
    {
        public static readonly DependencyProperty IsOpenProperty =
            DependencyProperty.Register("IsOpen", typeof(bool), typeof(Modal), new PropertyMetadata(false));

        public bool IsOpen
        {
            get { return (bool)GetValue(IsOpenProperty); }
            set { SetValue(IsOpenProperty, value); }
        }

        static Modal()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Modal), new FrameworkPropertyMetadata(typeof(Modal)));
            //BackgroundProperty.OverrideMetadata(typeof(Modal), new FrameworkPropertyMetadata(CreateDefaultBackground()));
            //BackgroundProperty.OverrideMetadata(typeof(Modal), new FrameworkPropertyMetadata(new PropertyChangedCallback(onBackgroundChanged)));
        }

        private static void onBackgroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //var background = d.GetValue(BackgroundProperty);
            //string boop = background.ToString();
            //d.SetValue(BackgroundProperty, new SolidColorBrush(Color.) { Opacity = 0.3 });
        }

        //private static object CreateDefaultBackground()
        //{
        //    //return new SolidColorBrush(Colors.Black)
        //    //{
        //    //    Opacity = 0.5
        //    //};
        //    //return new SolidColorBrush(Colors.Black);
        //}

    }
}
