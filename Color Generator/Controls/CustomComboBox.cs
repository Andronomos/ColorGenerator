using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Color_Generator.Controls
{
    public class CustomComboBox : ComboBox
    {
        //Menu
        public static DependencyProperty MenuBackgroundProperty =
            DependencyProperty.Register("MenuBackground", typeof(Brush), typeof(CustomComboBox));

        public static DependencyProperty MenuBorderBrushProperty =
            DependencyProperty.Register("MenuBorderBrush", typeof(Brush), typeof(CustomComboBox));

        public static DependencyProperty MenuBorderThicknessProperty =
            DependencyProperty.Register("MenuBorderThickness", typeof(Thickness), typeof(CustomComboBox));

        public static DependencyProperty MenuCornerRadiusProperty =
            DependencyProperty.Register("MenuCornerRadius", typeof(CornerRadius), typeof(CustomComboBox));

        public Brush MenuBackground
        {
            get => (Brush)GetValue(MenuBackgroundProperty);
            set => SetValue(MenuBackgroundProperty, value);
        }

        public Brush MenuBorderBrush
        {
            get => (Brush)GetValue(MenuBorderBrushProperty);
            set => SetValue(MenuBorderBrushProperty, value);
        }

        public Thickness MenuBorderThickness
        {
            get => (Thickness)GetValue(MenuBorderThicknessProperty);
            set => SetValue(MenuBorderThicknessProperty, value);
        }

        public CornerRadius MenuCornerRadius
        {
            get => (CornerRadius)GetValue(MenuCornerRadiusProperty);
            set => SetValue(MenuCornerRadiusProperty, value);
        }

        //Menu Item
        public static DependencyProperty ItemSelectedProperty =
            DependencyProperty.Register("ItemSelected", typeof(Brush), typeof(CustomComboBox));

        public static DependencyProperty ItemMouseOverProperty =
            DependencyProperty.Register("ItemMouseOver", typeof(Brush), typeof(CustomComboBox));

        public Brush ItemSelected
        {
            get => (Brush)GetValue(ItemSelectedProperty);
            set => SetValue(ItemSelectedProperty, value);
        }

        public Brush ItemMouseOver
        {
            get => (Brush)GetValue(ItemMouseOverProperty);
            set => SetValue(ItemMouseOverProperty, value);
        }


        //Arrow
        public static DependencyProperty ArrowFillProperty =
            DependencyProperty.Register("ArrowFill", typeof(Brush), typeof(CustomComboBox));

        public Brush ArrowFill
        {
            get => (Brush)GetValue(ArrowFillProperty);
            set => SetValue(ArrowFillProperty, value);
        }

        //Misc
        public static DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(CustomComboBox));

        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }


        static CustomComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomComboBox), new FrameworkPropertyMetadata(typeof(CustomComboBox)));
        }
    }
}
