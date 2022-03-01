using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Color_Generator.Controls
{
    public class CustomSlider : Slider
    {
        /** Thumb **/
        public static readonly DependencyProperty ThumbProperty =
            DependencyProperty.Register("Thumb", typeof(Brush), typeof(CustomSlider), new FrameworkPropertyMetadata(Brushes.Orange));

        public Brush Thumb
        {
            get => (Brush)GetValue(ThumbProperty);
            set => SetValue(ThumbProperty, value);
        }

        public static readonly DependencyProperty ThumbStrokeProperty =
           DependencyProperty.Register("ThumbStroke", typeof(Brush), typeof(CustomSlider), new FrameworkPropertyMetadata(Brushes.BurlyWood));

        public Brush ThumbStroke
        {
            get => (Brush)GetValue(ThumbStrokeProperty);
            set => SetValue(ThumbStrokeProperty, value);
        }

        public static readonly DependencyProperty ThumbStrokeThicknessProperty =
           DependencyProperty.Register("ThumbStrokeThickness", typeof(Thickness), typeof(CustomSlider));

        public Thickness ThumbStrokeThickness
        {
            get => (Thickness)GetValue(ThumbStrokeThicknessProperty);
            set => SetValue(ThumbStrokeThicknessProperty, value);
        }

        /** Ticks **/
        public static readonly DependencyProperty TickColorProperty =
            DependencyProperty.Register("TickColor", typeof(Brush), typeof(CustomSlider), new FrameworkPropertyMetadata(Brushes.Aquamarine));

        public Brush TickColor
        {
            get => (Brush)GetValue(TickColorProperty);
            set => SetValue(TickColorProperty, value);
        }

        /** Buttons **/
        public static readonly DependencyProperty DecreaseButtonProperty =
           DependencyProperty.Register("DecreaseRepeatButton", typeof(Brush), typeof(CustomSlider), new FrameworkPropertyMetadata(Brushes.Cornsilk));

        public Brush DecreaseRepeatButton
        {
            get => (Brush)GetValue(DecreaseButtonProperty);
            set => SetValue(DecreaseButtonProperty, value);
        }

        public static readonly DependencyProperty IncreaseButtonProperty =
           DependencyProperty.Register("IncreaseRepeatButton", typeof(Brush), typeof(CustomSlider), new FrameworkPropertyMetadata(Brushes.Coral));

        public Brush IncreaseRepeatButton
        {
            get => (Brush)GetValue(IncreaseButtonProperty);
            set => SetValue(IncreaseButtonProperty, value);
        }
    }
}
