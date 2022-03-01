using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace Color_Generator.Controls
{
    public class ToggleSwitch : CheckBox
    {
        /** Track **/
        public static DependencyProperty TrackCornerRadiusProperty =
            DependencyProperty.Register("TrackCornerRadius", typeof(CornerRadius), typeof(ToggleSwitch));

        public CornerRadius TrackCornerRadius
        {
            get => (CornerRadius)GetValue(TrackCornerRadiusProperty);
            set => SetValue(TrackCornerRadiusProperty, value);
        }

        public static DependencyProperty TrackHeightProperty =
            DependencyProperty.Register("TrackHeight", typeof(int), typeof(ToggleSwitch));

        public int TrackHeight
        {
            get => (int)GetValue(TrackHeightProperty);
            set => SetValue(TrackHeightProperty, value);
        }

        /** Thumb **/
        public static DependencyProperty ThumbBackgroundProperty =
            DependencyProperty.Register("ThumbBackground", typeof(Brush), typeof(ToggleSwitch));

        public Brush ThumbBackground
        {
            get => (Brush)GetValue(ThumbBackgroundProperty);
            set => SetValue(ThumbBackgroundProperty, value);
        }

        public static DependencyProperty ThumbCornerRadiusProperty =
            DependencyProperty.Register("ThumbCornerRadius", typeof(CornerRadius), typeof(ToggleSwitch));

        public CornerRadius ThumbCornerRadius
        {
            get => (CornerRadius)GetValue(ThumbCornerRadiusProperty);
            set => SetValue(ThumbCornerRadiusProperty, value);
        }

        public static DependencyProperty ThumbWidthProperty =
            DependencyProperty.Register("ThumbWidth", typeof(int), typeof(ToggleSwitch));

        public int ThumbWidth
        {
            get => (int)GetValue(ThumbWidthProperty);
            set => SetValue(ThumbWidthProperty, value);
        }

        public static DependencyProperty ThumbHeightProperty =
            DependencyProperty.Register("ThumbHeight", typeof(int), typeof(ToggleSwitch));

        public int ThumbHeight
        {
            get => (int)GetValue(ThumbHeightProperty);
            set => SetValue(ThumbHeightProperty, value);
        }

        public static DependencyProperty ThumbMarginProperty =
            DependencyProperty.Register("ThumbMargin", typeof(Thickness), typeof(ToggleSwitch));

        public Thickness ThumbMargin
        {
            get => (Thickness)GetValue(ThumbMarginProperty);
            set => SetValue(ThumbMarginProperty, value);
        }

        public ToggleSwitch()
        {

        }
    }
}
