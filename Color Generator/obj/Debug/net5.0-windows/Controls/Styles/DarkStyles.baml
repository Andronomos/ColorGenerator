   M S B A M L   `   `   `  ����J  FColor Generator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Color_Generator.ControlsColor_Generator.Controls  5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� 
TargetType   
ButtonBase �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value  Dark.Btn.Primary �� BasedOn & "Dark.Btn.Primary.Static.Background & "Dark.Btn.Primary.Static.Foreground ) %Dark.Btn.Primary.MouseOver.Background ' #Dark.Btn.Primary.Pressed.Background  Dark.Btn.Secondary ( $Dark.Btn.Secondary.Static.Background ( $Dark.Btn.Secondary.Static.Foreground +	 'Dark.Btn.Secondary.MouseOver.Background )
 %Dark.Btn.Secondary.Pressed.Background  Dark.Btn.Danger % !Dark.Btn.Danger.Static.Background % !Dark.Btn.Danger.Static.Foreground ( $Dark.Btn.Danger.MouseOver.Background & "Dark.Btn.Danger.Pressed.Background  Dark.TextBox " Dark.TextBox.Static.Background " Dark.TextBox.Static.Foreground  Dark.PasswordBox  Dark.CheckBox-    'Color_Generator.Controls.CustomCheckBox # Dark.CheckBox.Static.Background # Dark.CheckBox.Static.Foreground  Dark.CheckBox.Checked.Check $  Dark.CheckBox.Checked.Background	 ]� 
Conditions
 �� Property �� Value  Dark.RadioButton0   *Color_Generator.Controls.CustomRadioButton & "Dark.RadioButton.Static.Background & "Dark.RadioButton.Static.Foreground " Dark.RadioButton.Checked.Check ' #Dark.RadioButton.Checked.Background  Dark.ToggleSwitch+   %Color_Generator.Controls.ToggleSwitch ' #Dark.ToggleSwitch.Static.Background '  #Dark.ToggleSwitch.Static.Foreground -! )Dark.ToggleSwitch.Static.Thumb.Background (" $Dark.ToggleSwitch.Checked.Background .# *Dark.ToggleSwitch.Checked.Thumb.Background $ Dark.ComboBox-   'Color_Generator.Controls.CustomComboBox #% Dark.ComboBox.Static.Background #& Dark.ComboBox.Static.Foreground #' Dark.ComboBox.Static.Arrow.Fill (( $Dark.ComboBox.Static.Menu.Background )) %Dark.ComboBoxItem.Selected.Background ** &Dark.ComboBoxItem.MouseOver.Background %+ !Dark.ComboBox.Editable.Background , Dark.Slider+   %Color_Generator.Controls.CustomSlider 0- ,Dark.Slider.Static.DecreaseButton.Background 0. ,Dark.Slider.Static.IncreaseButton.Background '/ #Dark.Slider.Static.Thumb.Background #0 Dark.Slider.Static.Thumb.Stroke 1 Dark.Slider.Static.Ticks %2 !Dark.Slider.Static.SelectionRange 3 Dark.ListView-   'Color_Generator.Controls.CustomListView #4 Dark.ListView.Static.Background #5 Dark.ListView.Static.Foreground *6 &Dark.ListViewItem.MouseOver.Background *7 &Dark.ListViewItem.MouseOver.Foreground )8 %Dark.ListViewItem.Selected.Background )9 %Dark.ListViewItem.Selected.Foreground�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      3controls&clr-namespace:Color_Generator.Controls  5      %�  &	        &	 ,    7   7  7  7  7  &	 R    7   7  7  7 	 7 
 &	 x    7   7  7  7  7  &	 �    7��7  7  &	 7    7G�7  7  &	 �	    7  7  7  7  7  7  &	 q    7 7  7  7  7  7  &	     7 7  7   7 ! 7 " 7 # &	$ ]    7 7 % 7 & 7 ' 7 ( 7 ) 7 * 7 + &	, �    7 7 - 7 . 7 / 7 0 7 1 7 2 &	3 O    7 7 4 7 5 7 6 7 7 7 8 7 9 �� 5      "  ��6   .�5   
   ��  � ��$ 0q�6,   �� 5   
    �@�Cursor$
 Hand��6#   �� 5   
    � ��$ Verdana)�6'   �� 5	   
    � ��$ 12(�6%   �� 5
   
    � �� �#FFF6'   �� 5   
    � ��$ 37��6#   �� 5   
    � ��$ Center=�67   �� 5   
    � ��$ 5 1 5 1q�6$   �� 5   
    � ��$ Center=�65   �� 5   
    � ��$
 Auto��6"   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      �� #��z��6   $ 2��6I   #��z��5      #��z��5      ._�5      �� #��z��6+   #��z��6N   #��z��5   +   $
��True��6j   5      5      5       5   
   P� 5       � {�$ False��6+   . �5      ��  �@�Cursor$ No��6+   �� 5       �@J�Opacity$	 0.5Q�6,   5       5"      �� 5$      8   "  ��6K   .�5%   
   ��  � ��8  6'   �� 5&   
    � ��8  6'    5'   
   P� 5(       �@J�IsMouseOver$
 True��6-   . �5)      ��  � ��8  66   5*      P� 5+       � ��$
 True��6+   . �5,      ��  � ��8  66   5-      5/      �� 51      8   "  ��6M   .�52   
   ��  � ��8  6'   �� 53   
    � ��8  6'    54   
   P� 55       �@J�IsMouseOver$
 True��6-   . �56      ��  � ��8  66   57      P� 58       � ��$
 True��6+   . �59      ��  � ��8  66   5:      5<      �� 5>      8   "  ��6J   .�5?   
   ��  � ��8  6'   �� 5@   
    � ��8  6'    5A   
   P� 5B       �@J�IsMouseOver$
 True��6-   . �5C      ��  � ��8  66   5D      P� 5E       � ��$
 True��6+   . �5F      ��  � ��8  66   5G      5I      �� 5K      8   "  ��6M   .�5L   
   ��  � ��8  6'   �� 5M   
    � ��8  6'   �� 5N   
    � ��$ Center=�65   �� 5O   
    � ��$ 37��6&   �� 5P   
    � ��$ 5 1 5 1q�6$   �� 5Q   
    � ��$ 0q�6,    5R   
   P� 5S       � {�$ False��6+   . �5T      ��  �@�Cursor$ No��6+   �� 5U       �@J�Opacity$	 0.9Q�6,   5V      5X      �� 5Z      8   "  G�6U   .�5[   
   ��  � ��8  6'   �� 5\   
    � ��8  6'   �� 5]   
    � ��$ Center=�65   �� 5^   
    � ��$ 37��6&   �� 5_   
    � ��$ 5 1 5 1q�6$   �� 5`   
    � ��$ 1q�6,    5a   
   P� 5b       � {�$ False��6+   . �5c      ��  �@�Cursor$ No��6+   �� 5d       �@J�Opacity$	 0.9Q�6,   5e      5g      �� 5i      8   "    6^   .�5j   
   ��  � ��8  6'   �� 5k   
    � ��8  6'   �� 5l   
    �@  CheckMarkBrush8  6+   �� 5m   
    � ��$ Center=�65   �� 5n   
    � ��$ 36��6&   �� 5o   
    � ��$ 5,0,0,0q�6$   �� 5p   
    � ��$ 0q�6,    5q   
   P� 5r       �@d�	IsChecked$
 TrueY�6+   . �5s      ��  � ��8  6/   5t      P� 5u       � {�$ False��6+   . �5v      ��  �@J�Opacity$	 0.5Q�6,   5w      ]� 5x      	 5y      �� 5z      
 � {�$ False��65   �� 5{      
 �@d�	IsChecked$
 TrueY�65   /�5}      �� 5~       � ��8  63   5�      5�      �� 5�      8   "   6d   .�5�   
   ��  � ��8  6'   �� 5�   
    � ��8  6'   �� 5�   
    �@ 	CheckFill8  6&   �� 5�   
    � ��$ Center=�65   �� 5�   
    � ��$ 36��6&   �� 5�   
    � ��$ 5,0,0,0q�6$   �� 5�   
    �@ StrokeThickness$ 0Q�6,    5�   
   P� 5�       �@d�	IsChecked$
 TrueY�6+   . �5�      ��  � ��8  6/   5�      P� 5�       � {�$ False��6+   . �5�      ��  �@J�Opacity$	 0.5Q�6,   5�      ]� 5�      	 5�      �� 5�      
 � {�$ False��65   �� 5�      
 �@d�	IsChecked$
 TrueY�65   /�5�      �� 5�       � ��8  63   5�      5�      �� 5�      8   "   6`   .�5�   
   ��  � ��8  6'   �� 5�   
    � ��8  6'   �� 5�   
    � ��$ 0q�6,   �� 5�   
    �@ ThumbMargin$ 3q�6(   �� 5�   
    �@ 
ThumbWidth$ 12��6'   �� 5�   
    �@ ThumbHeight$ 12��6(   �� 5�   
    �@ ThumbCornerRadius$	 320��6.   �� 5�   
    �@ ThumbBackground8  6,   �� 5�   
    �@ TrackHeight$ 20��6(   �� 5�   
    �@ TrackCornerRadius$ 10��6.    5�   
   P� 5�       �@d�	IsChecked$
 TrueY�6+   . �5�      ��  � ��8  6/   �� 5�       �@ ThumbBackground8  64   �� 5�       �@ ThumbMargin$ 0 3 3 3q�60   5�      P� 5�       � {�$ False��6+   . �5�      ��  �@�Cursor$ No��6+   �� 5�       �@J�Opacity$	 0.5Q�6,   5�      5�      �� 5�      8   "   6^   .�5�   
   ��  � ��8  6'   �� 5�   
    � ��8  6'   �� 5�   
    �@ 	ArrowFill8  6&   �� 5�   
    �@ MenuBackground8  6+   �� 5�   
    �@ MenuCornerRadius$ 0��6-   �� 5�   
    �@ ItemSelected8  6)   �� 5�   
    �@ ItemMouseOver8  6*   �� 5�   
    � ��$ Center=�65    5�   
   P� 5�       �@��
IsEditable$
 True��6,   . �5�      ��  �@�Cursor$
 None��6+   �� 5�       � ��8  6/   5�      P� 5�       � {�$ False��6+   . �5�      ��  �@�Cursor$
 None��6+   �� 5�       �@J�Opacity$	 0.5Q�6,   5�      5�      �� 5�      8   "   6Z   .�5�   
   ��  �@ DecreaseRepeatButton8  61   �� 5�   
    �@ IncreaseRepeatButton8  61   �� 5�   
    �@ 
ThumbBrush8  6'   �� 5�   
    �@ ThumbStroke8  6(   �� 5�   
    �@ ThumbStrokeThickness$ 0Q�61   �� 5�   
    �@ ThumbCornerRadius$ 3��6.   �� 5�   
    �@ 	TickColor8  6&   �� 5�   
    �@ SelectionRange8  6+    5�   
   P� 5�       � {�$ False��6+   . �5�      ��  �@ ThumbStrokeThickness$ 0Q�69   �� 5�       �@J�Opacity$	 0.5Q�6,   5�      5�      �� 5�      8   "   6^   .�5�   
   ��  � ��8  6'   �� 5�   
    � ��8  6'   �� 5�   
    �@ ItemMouseOverBackground8  64   �� 5�   
    �@ ItemMouseOverForeground8  64   �� 5�   
    �@ ItemSelectedBackground8  63   �� 5�   
    �@ ItemSelectedForeground8  63   �� 5�   
    �@�OverridesDefaultStyle$ False��62    5�   
   P� 5�       � {�$ False��6+   . �5�      ��  �@�Cursor$
 None��6+   �� 5�       �@J�Opacity$	 0.5Q�6,   5�      5�      5�      