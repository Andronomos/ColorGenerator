using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Color_Generator.Controls
{
    public class CustomTabControl : TabControl
    {
        //Tab Panel
        public static readonly DependencyProperty TabPanelBackgroundProperty =
           DependencyProperty.Register("TabPanelBackground", typeof(Brush), typeof(CustomTabControl));

        public static readonly DependencyProperty TabPanelBorderBrushProperty =
           DependencyProperty.Register("TabPanelBorderBrush", typeof(Brush), typeof(CustomTabControl));

        public static readonly DependencyProperty TabPanelBorderThicknessProperty =
            DependencyProperty.Register("TabPanelBorderThickness", typeof(Thickness), typeof(CustomTabControl));

        public static readonly DependencyProperty TabPanelUniformProperty =
            DependencyProperty.Register("TabPanelUniform", typeof(bool), typeof(CustomTabControl), new PropertyMetadata(false));

        public Brush TabPanelBackground
        {
            get { return (Brush)GetValue(TabPanelBackgroundProperty); }
            set { SetValue(TabPanelBackgroundProperty, value); }
        }

        public Brush TabPanelBorderBrush
        {
            get { return (Brush)GetValue(TabPanelBorderBrushProperty); }
            set { SetValue(TabPanelBorderBrushProperty, value); }
        }

        public Thickness TabPanelBorderThickness
        {
            get { return (Thickness)GetValue(TabPanelBorderThicknessProperty); }
            set { SetValue(TabPanelBorderThicknessProperty, value); }
        }

        public bool TabPanelUniform
        {
            get { return (bool)GetValue(TabPanelUniformProperty); }
            set { SetValue(TabPanelUniformProperty, value); }
        }


        //Tab Content
        public static readonly DependencyProperty TabContentBackgroundProperty =
           DependencyProperty.Register("TabContentBackground", typeof(Brush), typeof(CustomTabControl));

        public static readonly DependencyProperty TabContentBorderBrushProperty =
           DependencyProperty.Register("TabContentBorderBrush", typeof(Brush), typeof(CustomTabControl));

        public static readonly DependencyProperty TabContentBorderThicknessProperty =
            DependencyProperty.Register("TabContentBorderThickness", typeof(Thickness), typeof(CustomTabControl));


        public Brush TabContentBackground
        {
            get { return (Brush)GetValue(TabContentBackgroundProperty); }
            set { SetValue(TabContentBackgroundProperty, value); }
        }

        public Brush TabContentBorderBrush
        {
            get { return (Brush)GetValue(TabContentBorderBrushProperty); }
            set { SetValue(TabContentBorderBrushProperty, value); }
        }

        public Thickness TabContentBorderThickness
        {
            get { return (Thickness)GetValue(TabContentBorderThicknessProperty); }
            set { SetValue(TabContentBorderThicknessProperty, value); }
        }


        //Active Tab Item
        public static readonly DependencyProperty ActiveTabItemBackgroundProperty =
           DependencyProperty.Register("ActiveTabItemBackground", typeof(Brush), typeof(CustomTabControl));

        public static readonly DependencyProperty ActiveTabItemBorderBrushProperty =
          DependencyProperty.Register("ActiveTabItemBorderBrush", typeof(Brush), typeof(CustomTabControl));

        public static readonly DependencyProperty ActiveTabItemBorderThicknessProperty =
          DependencyProperty.Register("ActiveTabItemBorderThickness", typeof(Thickness), typeof(CustomTabControl));

        public static readonly DependencyProperty ActiveTabItemForegroundProperty =
          DependencyProperty.Register("ActiveTabItemForeground", typeof(Brush), typeof(CustomTabControl));


        public Brush ActiveTabItemBackground
        {
            get { return (Brush)GetValue(ActiveTabItemBackgroundProperty); }
            set { SetValue(ActiveTabItemBackgroundProperty, value); }
        }

        public Brush ActiveTabItemBorderBrush
        {
            get { return (Brush)GetValue(ActiveTabItemBorderBrushProperty); }
            set { SetValue(ActiveTabItemBorderBrushProperty, value); }
        }

        public Thickness ActiveTabItemBorderThickness
        {
            get { return (Thickness)GetValue(ActiveTabItemBorderThicknessProperty); }
            set { SetValue(ActiveTabItemBorderThicknessProperty, value); }
        }

        public Brush ActiveTabItemForeground
        {
            get { return (Brush)GetValue(ActiveTabItemForegroundProperty); }
            set { SetValue(ActiveTabItemForegroundProperty, value); }
        }


        //Tab Item
        public static readonly DependencyProperty TabItemBackgroundProperty =
            DependencyProperty.Register("TabItemBackground", typeof(Brush), typeof(CustomTabControl));

        public static readonly DependencyProperty TabItemBorderBrushProperty =
            DependencyProperty.Register("TabItemBorderBrush", typeof(Brush), typeof(CustomTabControl));

        public static readonly DependencyProperty TabItemBorderThicknessProperty =
            DependencyProperty.Register("TabItemBorderThickness", typeof(Thickness), typeof(CustomTabControl));

        public static readonly DependencyProperty TabItemForegroundProperty =
            DependencyProperty.Register("TabItemForeground", typeof(Brush), typeof(CustomTabControl));

        public static readonly DependencyProperty TabItemCornerRadiusProperty =
            DependencyProperty.Register("TabItemCornerRadius", typeof(CornerRadius), typeof(CustomTabControl));


        public Brush TabItemBackground
        {
            get { return (Brush)GetValue(TabItemBackgroundProperty); }
            set { SetValue(TabItemBackgroundProperty, value); }
        }

        public Brush TabItemBorderBrush
        {
            get { return (Brush)GetValue(TabItemBorderBrushProperty); }
            set { SetValue(TabItemBorderBrushProperty, value); }
        }

        public Thickness TabItemBorderThickness
        {
            get { return (Thickness)GetValue(TabItemBorderThicknessProperty); }
            set { SetValue(TabItemBorderThicknessProperty, value); }
        }

        public Brush TabItemForeground
        {
            get { return (Brush)GetValue(TabItemForegroundProperty); }
            set { SetValue(TabItemForegroundProperty, value); }
        }

        public CornerRadius TabItemCornerRadius
        {
            get { return (CornerRadius)GetValue(TabItemCornerRadiusProperty); }
            set { SetValue(TabItemCornerRadiusProperty, value); }
        }


        static CustomTabControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomTabControl), new FrameworkPropertyMetadata(typeof(CustomTabControl)));
        }
    }
}
