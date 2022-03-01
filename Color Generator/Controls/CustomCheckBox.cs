using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Color_Generator.Controls
{
    public class CustomCheckBox : CheckBox
    {
        public static readonly DependencyProperty CheckMarkBrushProperty =
            DependencyProperty.Register("CheckMarkBrush", typeof(Brush), typeof(CustomCheckBox));

        public static readonly DependencyProperty CornerRadiusProperty =
           DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(CustomCheckBox));


        public Brush CheckMarkBrush
        {
            get { return (Brush)GetValue(CheckMarkBrushProperty); }
            set { SetValue(CheckMarkBrushProperty, value); }
        }

        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        static CustomCheckBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomCheckBox), new FrameworkPropertyMetadata(typeof(CustomCheckBox)));
        }
    }
}
