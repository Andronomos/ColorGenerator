   M S B A M L   `   `   `  ����J  FColor Generator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Color_Generator.ControlsColor_Generator.Controls  5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   RepeatButtonTransparent  �� 
TargetType  RepeatButtonBase �� 
TargetType �� Property �� Value  DecreaseButton �� BasedOn �� RelativeSource �� AncestorType �� Triggers �� Value	 �� Binding
 �� 
TargetName �� Triggers  IncreaseButton  SliderThumbHorizontal ��Name �� Mode �� FallbackValue �� CornerRadius  SliderThumbVertical  CircularThumb A�Name+    %Color_Generator.Controls.CustomSlider P� Property P� Value � RowDefinitions m� 	Placement m� Fill ��Name ]� DecreaseRepeatButton ]� Thumb n�Name ]� IncreaseRepeatButton � ColumnDefinitions m�Name ]�Name�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     6W   0local&clr-namespace:Color_Generator.Controls  5      %�  &	        &	 V     &	 *    7  7   &	 L    7  7   &	 (    &	 �	    &	 g    '   �    7  7  7  7  7  7  �� 5      "  ��66   .R�5   
   �� #��z��6   #��z��68   #��z��6Z   5      �� 5      " ��6%   .�5	   
   ��  �@�OverridesDefaultStyle$
 True��62   �� 5
   
    � ��
 ���� 6'   �� 5   
    � |�$ False��6&   �� 5   
    � ��$ False��6&   5      �� 5      8   " ��6O   .�5   
   ��  � �� 5      �� 5      "  ��6"   .R�5      �� #��z��6   #��z��6?   ._�5      �� $
��rect��6$   $	��5.0��6�   $	��5.0��6�   ��60   �� *DecreaseRepeatButton+ ��  local:CustomSlider6�   5       5      �� 5      $ Vertical��6�   	 6&   �� *Orientation+ ��  local:CustomSlider.a�5      �� $

 rect��67    � ��$
 Auto��6I   5      �� 5      $ 
Horizontal��6�   	 6&   �� *Orientation+ ��  local:CustomSlider.a�5      �� $

 rect��66    � ��$
 Auto��6H   5      5      5        5!   
   �� 5"      	 6   �� *IsSelectionRangeEnabled+ �� *TemplatedParent+ True6w   .a�5#      ��  � ��8  6-   5$      5&      �� 5(      8   " ��6O   .�5)   
   ��  � �� 5*      �� 5+      "  ��6"   .R�5,      �� #��z��6   #��z��6?   #��z��6_   ._�5-      �� $
��rect��6$   $	��5.0��60   $	��5.0��6<   5.       5/      �� 50      $ Vertical��6w   	 6&   �� *Orientation+ �� *TemplatedParent+.a�51      �� $

 rect��67    � ��$
 Auto��6I   52      �� 53      $ 
Horizontal��6w   	 6&   �� *Orientation+ �� *TemplatedParent+.a�54      �� $

 rect��66    � ��$
 Auto��6H   55      57      59       5:   
   �� 5;      	 6   �� *IsSelectionRangeEnabled+ �� *TemplatedParent+ True6w   .a�5<      ��  � ��8  6-   5=      5?      �� 5B      " n�6*   .�5C   
   ��  �@J�SnapsToDevicePixels$
 True��60   �� 5D   
    �@�OverridesDefaultStyle$
 True��62   �� 5E   
    � ��$ Center=�6.   �� 5F   
    � |�$ False��6&   �� 5G   
    � �� 5H      �� 5I      "  n�6"   .R�5J      �� $
 grip��6   $��18��6+   $��11��67   ��5K      �� *
ThumbBrush+ ��  local:CustomSlider$ TwoWay=�$
 Gray����5L      �� *ThumbStroke+ ��  local:CustomSlider��5M      �� *ThumbStrokeThickness+ ��  local:CustomSlider 5N      �� *ThumbCornerRadius+ ��  local:CustomSlider5O      5Q      5R      �� 5T      " n�6(   .�5U   
   ��  �@J�SnapsToDevicePixels$
 True��60   �� 5V   
    �@�OverridesDefaultStyle$
 True��62   �� 5W   
    � ��$	 Top=�6.   �� 5X   
    � |�$ False��6&   �� 5Y   
    � �� 5Z      �� 5[      "  n�6"   .R�5\      �� $
 grip��6   $��11��6+   $��18��67   ��5]      �� *
ThumbBrush+ ��  local:CustomSlider$ TwoWay=�$
 Gray����5^      �� *ThumbStroke+ ��  local:CustomSlider��5_      �� *ThumbStrokeThickness+ ��  local:CustomSlider 5`      �� *ThumbCornerRadius+ ��  local:CustomSlider5a      5c      5d      �� 5f      " n�6"   .�5g   
   ��  �@J�SnapsToDevicePixels$
 True��60   �� 5h   
    �@�OverridesDefaultStyle$
 True��62   �� 5i   
    � ��$	 Top=�6.   �� 5j   
    � |�$ False��6&   �� 5k   
    � �� 5l      �� 5m      "  n�6"   .R�5n      A� $
 grip��6   $��18��6,   $��18��68   ��5o      �� *
ThumbBrush+ ��  local:CustomSlider$ TwoWay=�$
 Gray����5p      �� *ThumbStroke+ ��  local:CustomSlider��5q      �� *ThumbStrokeThickness+ ��  local:CustomSlider5r      5t      5u      �� 5x      "   6    5y   
   P� 5z       �@��Orientation$ 
Horizontal=�6-   . �5{      ��  � �� 5|      �� 5}      "    6*   .R�5~      �� ._�5   "   �  5�   &   �� 5�   *   $
��Auto �68   �� 5�   *   $
��Auto �68   #��z��6F   �� 5�   *   $
��Auto �68   .+�5�   &   m� $��TopTick��6.   $��4��6=   $��0,0,0,4q�6H   $	 Top=�6Y   $��0��6i   $y�	Collapsed=�6v    5�   .   �� *	TickColor+ ��  local:CustomSlider$ TwoWay=�m� 5�   &   $��
BottomTick��6.   $��4��6@   $��0,4,0,0q�6K   $ Bottom=�6\   $��2��6o   $y�	Collapsed=�6|    5�   .   �� *	TickColor+ ��  local:CustomSlider$ TwoWay=��� 5�   &   $ IncreaseRepeatButton��6-   $��1��6K   $��Center=�6X   $	��5.0��6s   #��z��5�   -   #��z��6a   ��5�   -   �� *IncreaseRepeatButton+ ��  local:CustomSlider$ TwoWay=�._�5�   *   �� .+�5�   .   �� $ PART_SelectionRange��68   $y�Hidden=�5�   8   $��4��6L   ��5�   8   �� *SelectionRange+ ��  local:CustomSlider$ TwoWay=�5�   L   5�   +   5�   '   ]� 5�   &   $��
PART_Track��6,   $��1��6>    5�   *   �� 5�   .   8��  $��Slider.DecreaseLarge��6c    5�   *   n� 5�   .   $ Thumb��64   8�� 6C    5�   *   �� 5�   .   8�� $��Slider.IncreaseLarge��6c   5�   '   5�   #   5�       5�      P� 5�   "    �@��TickPlacement$
 Both=�6C   . �5�   &   �� $
 TopTick��6S    � y�$ Visible=�6C   6S   �� 5�   &   $
 
BottomTick��6S    � y�$ Visible=�6C   6S   5�   #   P� 5�   "    �@��TickPlacement$ TopLeft=�6C   . �5�   &   �� $
 TopTick��6S    � y�$ Visible=�6C   6S   �� 5�   &   $
 
BottomTick��6U    � y�$ 	Collapsed=�6C   6U   5�   #   P� 5�   "    �@��TickPlacement$ BottomRight=�6C   . �5�   &   �� $
 TopTick��6U    � y�$ 	Collapsed=�6C   6U   �� 5�   &   $
 
BottomTick��6S    � y�$ Visible=�6C   6S   5�   #   P� 5�   "    �@��IsSelectionRangeEnabled$
 True��6M   . �5�   &   �� $
 PART_SelectionRange��6C    � y�$ Visible=�6d   5�   #   5�      5�      5�      P� 5�       �@��Orientation$ Vertical=�6-   . �5�      ��  � �� 5�      �� 5�      "    6*   .R�5�      �� ._�5�   "   �  5�   &   �� 5�   *   $
��Auto �6;   �� 5�   *   #��z��6;   $
��Auto �6a   �� 5�   *   $
��Auto �6;   .+�5�   &   m� $ TopTick��6.   $y�	Collapsed=�6?   $��0��6V   $��0,0,4,0q�6f   $
 Left=�6w   $��4��6�    5�   .   �� *	TickColor+ ��  local:CustomSlider$ TwoWay=�m� 5�   &   $ 
BottomTick��6.   $y�	Collapsed=�6B   $��2��6Y   $��4,0,0,0q�6i   $ Right=�6z   $��4��6�    5�   .   �� *	TickColor+ ��  local:CustomSlider$ TwoWay=��� 5�   &   $ IncreaseButton��6-   $��1��6E   $��Center=�6U   $	��5.0��6r   #��z��5�   -   #��z��5�   -   ��5�   -   �� *IncreaseRepeatButton+ ��  local:CustomSlider$ TwoWay=�._�5�   *   �� .+�5�   .   �� $ PART_SelectionRange��68   $y�Hidden=�5�   8   $��4��6L   ��5�   8   �� *SelectionRange+ ��  local:CustomSlider$ TwoWay=�5�   L   5�   +   5�   '   ]� 5�   &   $ 
PART_Track��6,   $��1��6@    5�   *   �� 5�   .   8�� $��Slider.DecreaseLarge��6c    5�   *   n� 5�   .   $ Thumb��64   8�� 6C    5�   *   �� 5�   .   8�� $��Slider.IncreaseLarge��6c   5�   '   5�   #   5�       5�      P� 5�   "    �@��TickPlacement$
 Both=�6C   . �5�   &   �� $
 TopTick��6S    � y�$ Visible=�6C   6S   �� 5�   &   $
 
BottomTick��6S    � y�$ Visible=�6C   6S   5�   #   P� 5�   "    �@��TickPlacement$ TopLeft=�6C   . �5�   &   �� $
 TopTick��6S    � y�$ Visible=�6C   6S   �� 5�   &   $
 
BottomTick��6U    � y�$ 	Collapsed=�6C   6U   5�   #   P� 5�   "    �@��TickPlacement$ BottomRight=�6C   . �5�   &   �� $
 TopTick��6U    � y�$ 	Collapsed=�6C   6U   �� 5�   &   $
 
BottomTick��6S    � y�$ Visible=�6C   6S   5�   #   P� 5�   "    �@��IsSelectionRangeEnabled$
 True��6M   . �5�   &   �� $
 PART_SelectionRange��6C    � y�$ Visible=�6d   5�   #   5�      5�      5�      5�      5�      