   M S B A M L   `   `   `  ����J  FColor Generator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Color_Generator.ControlsColor_Generator.Controls  5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ComboBoxToggleButton  �� 
TargetType �� Property �� Value �� 
TargetType ��Name J� SnapsToDevicePixels F�Name �� RelativeSource �� Mode	 �� AncestorType
 �� Triggers P� Property P� Value  ComboBoxTemplate-    'Color_Generator.Controls.CustomComboBox �Name � ColumnDefinitions �Name � AllowsTransparency �� Mode � ActualWidth �� MaxDropDownHeight �� CornerRadius ��Name ��Name-  'System.Windows.Input.KeyboardNavigation   DirectionalNavigation d�Name d� 	IsChecked ��Name �� SelectionBoxItemTemplate �� SelectionBoxItem# �� SelectionBoxItemStringFormat �� ContentStringFormat J� IsHitTestVisible  �� 
TargetName  ComboBoxEditableTextBox  ComboBoxEditableTemplate! ��Name" �� 
IsReadOnly# ]� 
Conditions$ �� Property% �� Value& �� Padding' �� Triggers�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      0local&clr-namespace:Color_Generator.Controls  5      %1  &	        &	 �    7   &	 �	    &	     7   7  '�� �    '   �    7  7  �� 5      "  d�6)   .�5   
   ��  �@�OverridesDefaultStyle$
 true��62   �� 5   
    � ��$ false��6&   �� 5   
    � |�$ false��6&   �� 5	   
    �@��	ClickMode$ Press=�6&   �� 5
   
    � �� 5      �� 5      " d�6"   .R�5      �� $ templateRoot��6   $
 true��63   #��z��5      #��z��5      #��z��5      ._�5      �� $ splitBorder��6!   #��� r�66   $
 true��6�   $��0q�6�   $��Right=�5   !   $��1q�6=   
������ ._�5      F� $ arrow��6#   $��Center=�62   $��0q�6M   $��Center=�6X   F����        ���( ��( јaQ     јaQ P����̰( � �    P����        ��5   #   �� *	ArrowFill+ �� $ FindAncestor=�	 local:CustomComboBox5   #   5      5      
 5      P� 5       �@J�IsMouseOver$
 True��69   . �5      ��  �@�Cursor$
 Hand��67   5      5      5      5       �� 5#      "   6/   .R�5$   
   � $ templateRoot��6   $
 true��6%    5%      �� 5&      $��* �6#   �� 5'      #��� r�6#   $��0 �6v   .+�5*      � $ 
PART_Popup��6   $
 true��6(   $��2��6B   $��1q�5+      $��Slide=�6   $��Bottom=�66   ��5*   V   �� *IsDropDownOpen+$ TwoWay=� �� *TemplatedParent+.��5,      � $ DropDown��6   $
 True��6)   #��z 6D   #��z 6m   .+�5-      �� $ dropDownBorder��6   $��0,0,0,0q�65   ��5.      �� *MenuBorderThickness+ �� $ FindAncestor=�	 local:CustomComboBox��5/      �� *MenuBackground+ �� $ FindAncestor=�	 local:CustomComboBox��50      �� *MenuBorderBrush+ �� $ FindAncestor=�	 local:CustomComboBox 51      �� *MenuCornerRadius+ �� $ FindAncestor=�	 local:CustomComboBox._�52      �� $ DropDownScrollViewer��6'   $
 True��6E   .��53      �� $ ItemsPresenter��6-   $ 	Contained=�6E   # z 54   -   55      56      57      58      d� 5:      $ toggleButton��6   #��z��61   #��z��6]   #��z��5;      $��2��6E   8��   5<      �� *IsDropDownOpen+$ TwoWay=� �� *TemplatedParent+5=      �� 5?      $ ContentSite��6   #��z 64   #��z��5@      #��z 5A      # z 5B      #��z��5C      $ false��5D      #��z��68   # z 5E      #��z��5F      5G      
 5H   
   P� 5I       �@��HasItems$ false��6*   . �5J      �� $  dropDownBorder��6+    � ��$ 35��6G   5K      5M      �� 5P      "  ��6,   .�5Q   
   ��  �@�OverridesDefaultStyle$
 true��62   �� 5R   
    �@J�	AllowDrop$
 true��6&   �� 5S   
    � ��$ 0��6%   �� 5T   
    � ��$ 0��6&   �� 5U   
    �@�FocusVisualStyle 6-   Z� �� 5V   
    �@��PanningMode$ VerticalFirst=�65   �� 5W   
    �@��IsFlicksEnabled$ False��63   �� 5X   
    � ��$ Center=�6.   �� 5Y   
    � �� 5Z      �� 5[      " ��6"   .R�5\      �� $ PART_ContentHost��6#   
������ $|�false��6V   $��Hidden=�6h   $��Hidden=�5]   #   5^      5`      5a      �� 5d      "   67   .R�5e   
   � $ templateRoot��6   $
 true��6%    5f      �� 5g      $��* �6#   �� 5h      #��� r�6#   $��0 �6v   .+�5j      � $ 
PART_Popup��6   $
 true��6(   $��2��6B   $��Slide=�5k      $��Bottom=�6+   ��5j   V   �� *IsDropDownOpen+ �� *TemplatedParent+.��5l      � $ DropDown��6   $
 True��6)   #��z 6D   #��z 6m   .+�5m      �� $ dropDownBorder��6   ��5n      �� *MenuBorderThickness+ �� $ FindAncestor=�	 local:CustomComboBox��5o      �� *MenuBackground+ �� $ FindAncestor=�	 local:CustomComboBox��5p      �� *MenuBorderBrush+ �� $ FindAncestor=�	 local:CustomComboBox._�5q      �� $ DropDownScrollViewer��6'   $
 True��6E   .��5r      �� $ ItemsPresenter��6-   $ 	Contained=�6E   # z 5s   -   5t      5u      5v      5w      d� 5x      $ toggleButton��6   #��z��61   #��z��6]   #��z��6�   $��2��5y      8��   6/   �� *IsDropDownOpen+$ TwoWay=� �� *TemplatedParent+5z      �� 5{      $ border��6   #��z��6%   ._�5|      �� $! PART_EditableTextBox��6   #��z��68   #��z��5}   m   8�� #��z��5~   K   " 5}      �� *
IsReadOnly+ �� *TemplatedParent+5~   K   5      5�      
 5�   
   ]� 5�      # 5�      �� 5�      $ �@��
IsGrouping$
% true��66   �� 5�      "$ �@%�IsVirtualizingWhenGrouping$% false��6X   ./�5�      ��  � ��$ false��6B   5�      P� 5�       �@��HasItems$ false��6*   . �5�      �� $  dropDownBorder��6+    � ��$ 35��6G   5�      5�      �� 5�      "  ��6*   .�5�   
   ��  �@J�SnapsToDevicePixels$
 True��60   �� 5�   
    �@�OverridesDefaultStyle$
 True��62   �� 5�   
    � ��$ 	3,10,3,10q�6$   �� 5�   
    � �� 5�      �� 5�      " ��6"   .R�5�      �� $ Border��6   $
 true��6-   
������ #& z��6a   ._�5�      �� #��z��6+   # z 5�   +   #��z��6g   5�      
 5�      P� 5�       �@J�IsMouseOver$
 True��69   . �5�      �� $  Border��6%    5�   %   �� *ItemMouseOver+ �� $ FindAncestor=�	 local:CustomComboBox � ��5�      P� 5�       �@J�IsKeyboardFocused$
 True��6?   . �5�      �� $  Border��6%    5�   %   �� *ItemMouseOverBrush+ �� $ FindAncestor=�	 local:CustomComboBox � ��5�      P� 5�       �@��IsHighlighted$
 True��6;   . �5�      �� $  Border��6%    5�   %   �� *ItemSelected+ �� $ FindAncestor=�	 local:CustomComboBox � ��5�      5�      5�      5�      �� 5�      "    62   .�5�   
   ��  � �� 6'   �� *
Background+�� 5�   
    � ��$ 0q�6,   �� 5�   
    �@J�SnapsToDevicePixels$
 True��60   �� 5�   
    � ��$	 120��6%   �� 5�   
    � ��$ 30��6&   �� 5�   
    � ��$ 6,3,5,3q�6$   �� 5�   
    � ��$
 Auto=�6G   �� 5�   
    � ��$
 Auto=�6E   �� 5�   
    � ��$
 true��6:   �� 5�   
    �@��PanningMode$
 Both=�65   �� 5�   
    �@��IsFlicksEnabled$ False��63   �� 5�   
    � ��8   6%   ' 5�   
   P� 5�       �@��
IsEditable$
 True��6,   . �5�      ��  � ��$ false��6.   �� 5�       � ��$ 2q�6,   �� 5�       � ��8  6-   5�      P� 5�       � {�$ False��6+   . �5�      ��  �@�Cursor$
 None��6+   �� 5�       �@J�Opacity$ .5Q�6,   5�      5�      5�      