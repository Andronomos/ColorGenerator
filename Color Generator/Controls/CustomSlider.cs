using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Color_Generator.Controls
{
    public class CustomSlider : Slider
    {
        /** Thumb **/
        public static readonly DependencyProperty ThumbBrushProperty =
           DependencyProperty.Register("ThumbBrush", typeof(Brush), typeof(CustomSlider), new FrameworkPropertyMetadata(Brushes.Orange));

        public Brush ThumbBrush
        {
            get => (Brush)GetValue(ThumbBrushProperty);
            set => SetValue(ThumbBrushProperty, value);
        }

        public static readonly DependencyProperty ThumbStrokeProperty =
           DependencyProperty.Register("ThumbStroke", typeof(Brush), typeof(CustomSlider), new FrameworkPropertyMetadata(Brushes.BurlyWood));

        public Brush ThumbStroke
        {
            get => (Brush)GetValue(ThumbStrokeProperty);
            set => SetValue(ThumbStrokeProperty, value);
        }

        public static readonly DependencyProperty ThumbStrokeThicknessProperty =
           DependencyProperty.Register("ThumbStrokeThickness", typeof(double), typeof(CustomSlider));

        public double ThumbStrokeThickness
        {
            get => (double)GetValue(ThumbStrokeThicknessProperty);
            set => SetValue(ThumbStrokeThicknessProperty, value);
        }

        public static readonly DependencyProperty ThumbCornerRadiusProperty =
           DependencyProperty.Register("ThumbCornerRadius", typeof(CornerRadius), typeof(CustomSlider));

        public CornerRadius ThumbCornerRadius
        {
            get => (CornerRadius)GetValue(ThumbCornerRadiusProperty);
            set => SetValue(ThumbCornerRadiusProperty, value);
        }

        /** Ticks **/
        public static readonly DependencyProperty TickColorProperty =
            DependencyProperty.Register("TickColor", typeof(Brush), typeof(CustomSlider), new FrameworkPropertyMetadata(Brushes.Aquamarine));

        public Brush TickColor
        {
            get => (Brush)GetValue(TickColorProperty);
            set => SetValue(TickColorProperty, value);
        }

        /** Track **/
        public static readonly DependencyProperty IncreaseRepeatButtonProperty =
            DependencyProperty.Register("IncreaseRepeatButton", typeof(Brush), typeof(CustomSlider), new FrameworkPropertyMetadata(Brushes.Cornsilk));

        public Brush IncreaseRepeatButton
        {
            get => (Brush)GetValue(IncreaseRepeatButtonProperty);
            set => SetValue(IncreaseRepeatButtonProperty, value);
        }

        /** Buttons **/
        public static readonly DependencyProperty DecreaseRepeatButtonProperty =
            DependencyProperty.Register("DecreaseRepeatButton", typeof(Brush), typeof(CustomSlider), new FrameworkPropertyMetadata(Brushes.Cornsilk));

        public Brush DecreaseRepeatButton
        {
            get => (Brush)GetValue(DecreaseRepeatButtonProperty);
            set => SetValue(DecreaseRepeatButtonProperty, value);
        }

        /** Misc **/
        public static readonly DependencyProperty SelectionRangeProperty =
            DependencyProperty.Register("SelectionRange", typeof(Brush), typeof(CustomSlider), new FrameworkPropertyMetadata(Brushes.Cornsilk));

        public Brush SelectionRange
        {
            get => (Brush)GetValue(SelectionRangeProperty);
            set => SetValue(SelectionRangeProperty, value);
        }
    }
}
