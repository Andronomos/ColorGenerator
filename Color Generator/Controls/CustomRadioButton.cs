using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Color_Generator.Controls
{
    public class CustomRadioButton : RadioButton
    {
        public static readonly DependencyProperty CheckFillProperty =
           DependencyProperty.Register("CheckFill", typeof(Brush), typeof(CustomRadioButton));

        public static readonly DependencyProperty StrokeThicknessProperty =
            DependencyProperty.Register("StrokeThickness", typeof(double), typeof(CustomRadioButton), new UIPropertyMetadata(2.0));

        public Brush CheckFill
        {
            get => (Brush)GetValue(CheckFillProperty);
            set => SetValue(CheckFillProperty, value);
        }

        public double StrokeThickness
        {
            get => (double)GetValue(StrokeThicknessProperty);
            set => SetValue(StrokeThicknessProperty, value);
        }

        private static void OnStrokeThicknessChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (((CustomRadioButton)d).StrokeThickness < 1)
                ((CustomRadioButton)d).StrokeThickness = 2;
        }

        static CustomRadioButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomRadioButton), new FrameworkPropertyMetadata(typeof(CustomRadioButton)));
        }
    }
}