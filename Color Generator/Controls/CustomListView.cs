using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Color_Generator.Controls
{
    public class CustomListView : ListView
    {
        public static readonly DependencyProperty ItemSelectedBackgroundProperty =
          DependencyProperty.Register("ItemSelectedBackground", typeof(Brush), typeof(CustomListView));

        public static readonly DependencyProperty ItemSelectedForegroundProperty =
          DependencyProperty.Register("ItemSelectedForeground", typeof(Brush), typeof(CustomListView));

        public static readonly DependencyProperty ItemMouseOverBackgroundProperty =
          DependencyProperty.Register("ItemMouseOverBackground", typeof(Brush), typeof(CustomListView));

        public static readonly DependencyProperty ItemMouseOverForegroundProperty =
          DependencyProperty.Register("ItemMouseOverForeground", typeof(Brush), typeof(CustomListView));

        public Brush ItemSelectedBackground
        {
            get { return (Brush)GetValue(ItemSelectedBackgroundProperty); }
            set { SetValue(ItemSelectedBackgroundProperty, value); }
        }

        public Brush ItemSelectedForeground
        {
            get { return (Brush)GetValue(ItemSelectedForegroundProperty); }
            set { SetValue(ItemSelectedForegroundProperty, value); }
        }

        public Brush ItemMouseOverBackground
        {
            get { return (Brush)GetValue(ItemMouseOverBackgroundProperty); }
            set { SetValue(ItemMouseOverBackgroundProperty, value); }
        }

        public Brush ItemMouseOverForeground
        {
            get { return (Brush)GetValue(ItemMouseOverForegroundProperty); }
            set { SetValue(ItemMouseOverForegroundProperty, value); }
        }

        static CustomListView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomListView), new FrameworkPropertyMetadata(typeof(CustomListView)));
        }
    }
}
