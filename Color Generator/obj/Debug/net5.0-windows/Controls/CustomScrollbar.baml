   M S B A M L   `   `   `  ����W  SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ScrollBarLineButton  �� 
TargetType �� Property �� Value  Scrollbar.Thumb.Background �� Path �� RelativeSource  ScrollBarPageButton �� 
TargetType  Scrollbar.Track.Background  ScrollBarThumb ��Name �� CornerRadius �� Triggers	 P� Property
 P� Value �� 
TargetName  ScrollbarTrack �� Triggers � RowDefinitions ]� IncreaseRepeatButton ]� Thumb ]� DecreaseRepeatButton � ColumnDefinitions �� CanContentScroll ��Name �� VerticalOffset � Value �� ScrollableHeight � Maximum �� ViewportHeight �� ViewportSize* �� #ComputedVerticalScrollBarVisibility �� Orientation �� HorizontalOffset �� ScrollableWidth �� ViewportWidth, �� %ComputedHorizontalScrollBarVisibility�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %W  &	        7  &	 �    7  &	     7  '�� Q    7  7   7  7  7   7  7   7  7  7   '�� n    �� 5      "  ��6(   .�5   
   ��  �@J�SnapsToDevicePixels$
 True��60   �� 5   
    �@�OverridesDefaultStyle$
 True��62   �� 5   
    � |�$ False��6&   �� 5   
    � �� 5	      �� 5
      .R�5      �� $��Border��6   
������ 
������ $��0q�6^   ._�5      F� $��Center=�6   $��Center=�6<   8��  ��5      �� $ Content� �� *TemplatedParent+5      5      5      5      �� 5      "  ��6(   .�5   
   ��  �@J�SnapsToDevicePixels$
 True��60   �� 5   
    �@�OverridesDefaultStyle$
 true��62   �� 5   
    � ��$ false��6&   �� 5   
    � |�$ false��6&   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      �� 8��  6   5      5       5!      �� 5#      "  n�6#   .�5$   
   ��  �@J�SnapsToDevicePixels$
 True��60   �� 5%   
    �@�OverridesDefaultStyle$
 True��62   �� 5&   
    � ��$ False��6&   �� 5'   
    � |�$ False��6&   �� 5(   
    � �� 5)      �� 5*      .R�5+      �� $ Thumb��6   8��  $��Stretch=�5,      $��Stretch=�6;   $ 0��6W   ._�5-      �� $��Stretch=�6$   $��Stretch=�6B   
������ 6^   5.       5/      P� 50      	 �@�Tag$
 Vertical��61   . �51      �� $ Thumb��6%    � ��$
 Auto��6I   �� 52      $ Thumb��6%    � ��$	 450��6M   53      P� 54      	 �@�Tag$
 
Horizontal��61   . �55      �� $ Thumb��6%    � ��$
 Auto��6I   �� 56      $ Thumb��6%    � ��$
 Auto��6J   57      59      5;      5<      �� 5>      "  ��6'   .�5?   
   ��  � ��# �  6%    5@   
   P� 5A      	 �@��Orientation$
 Vertical=�6-   . �5B      ��  � ��$
 Auto��6*   �� 5C       � ��$
 Auto��6+   �� 5D       � �� 5E      �� 5F      .R�5G      �  5H   "   �� 5I   &   $��18��64   �� 5J   &   $��0.00001* �64   �� 5K   &   $��18��64   .+�5N   "   �� $��3��6)   8��  6:   �� 5P   "   $��ScrollBar.LineUpCommand��6/   $��18��6Q   $��M 0 4 L 8 4 L 4 0 Z��5Q   /   8�� 5R   /   ]� 5T   "   $��
PART_Track��6(   $��1��6:   $
��True��6G    5U   &   �� 5V   *   $��ScrollBar.PageDownCommand��67   8�� 5W   7    5Y   &   n� 5Z   *   #���  60   $��1,0,1,0q�6Y    5\   &   �� 5]   *   $��ScrollBar.PageUpCommand��67   8�� 5^   7   5`   #   �� 5b   "   $��3��6/   $��ScrollBar.LineDownCommand��6<   $��18��6`   $��M 0 0 L 4 4 L 8 0 Z��5c   /   8�� 5d   /   5e      5f      5h      5i      P� 5j      	 �@��Orientation$
 
Horizontal=�6-   . �5k      ��  � �� 5l      �� 5m      .R�5n      �  5o   "   �� 5p   &   $��18��67   �� 5q   &   $��0.00001* �67   �� 5r   &   $��18��67   .+�5u   "   �� $��3��6)   8�� 6=   �� 5w   "   $��ScrollBar.LineLeftCommand��6/   $��18��6S   $��M 4 0 L 4 8 L 0 4 Z��5x   /   8�� 5y   /   ]� 5{   "   $��
PART_Track��6(   $��1��6:   $��False��6J    5|   &   �� 5}   *   $ ��ScrollBar.PageRightCommand��67   8�� 5~   ;    5�   &   n� 5�   *   #���  60   $��0,1,0,1q�6Y    5�   &   �� 5�   *   $��ScrollBar.PageLeftCommand��67   8�� 5�   ;   5�   #   �� 5�   "   8��	 $��18��6\   $��3��5�   /   $ ��ScrollBar.LineRightCommand��5�   /   $��M 0 0 L 4 4 L 0 8 Z��5�   /   5�      5�      5�      5�      5�      �� 5�      "  ��6   .�5�   
   ��  � �� 5�      �� 5�      " ��6"   .R�5�      �  5�      �� 5�      �� 5�      $
��Auto �6/    5�      �� 5�      �� 5�      $
��Auto �6,   .+�5�      �� $��0��61   #��z��5�   1   #��z��5�   1   #��z��5�   1   # z��5�   1   �� 5�      $ PART_VerticalScrollBar��6$   $��0��6D   $��1��6Q   # z 5�   $   # z 6M   # z 5�   $   #y�z 5�   $   �� 5�      $ PART_HorizontalScrollBar��6$   $ 
Horizontal=�6F   $��1��6_   $��0��5�   $   # z 64   # z 5�   $   # z 5�   $   #y�z 5�   $   5�      5�      5�      5�      5�      