   M S B A M L   `   `   `  ����J  FColor Generator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Color_Generator.ControlsColor_Generator.Controls  5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089/    )Color_Generator.Controls.CustomTabControl  �� BasedOn �� 
TargetType �� Property �� Value �� 
TargetType J� SnapsToDevicePixels-  'System.Windows.Input.KeyboardNavigation   TabNavigation � ColumnDefinitions �Name	 � RowDefinitions
 ��Name �� CornerRadius �� RelativeSource �� Mode K� IsItemsHost K� ZIndex   TabIndex   DirectionalNavigation �� SelectedContent �� SelectedContentTemplate" �� SelectedContentStringFormat �� ContentStringFormat �� Triggers P� Property P� Value �� 
TargetName �� 	Resources �� AncestorType �� Padding ��Name ]� 
Conditions �� Property  �� Value�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      0local&clr-namespace:Color_Generator.Controls  5      %  '         7��7���� 5      8    "   6c   .�5   
   ��  �@�OverridesDefaultStyle$
 True��62   �� 5   
    � �� 5      �� 5	      "   6"   .R�5
      � $
}�True��6   $
 True��6/   $ Local=�6J    5      �� 5      $
 Col0��6/   �� 5      $
 Col1��69   $��0 �6/   69   	 5      �� 5      $
 Row0��6:   $
��Auto �6,   6:   �� 5      $
 Row1��67   $��* �6,   67   .+�5      �� $
 TabPanelBorder��6!   $ 0��69   $��0,0,0,0q�6J   ��5   !   �� *TabPanelBackground+ �� $ TemplatedParent=���5   !   �� *TabPanelBorderBrush+ �� $ TemplatedParent=���5   !   �� *TabPanelBorderThickness+ �� $ TemplatedParent=�._�5      �� $��HeaderPanel��5   '   $
 True��5   '   $ 1��5   :   $ 1��6K   $��0��5   '   $��0��67   $��0,0,0,0q�6D   5      � 5      $��ContentPanel��6   $ 2��63   $ Local=�6S   $ 	Contained=�5      $��0��5      $��1��6/   .+�5       �� $ 0��5#   %   ��5    %   �� *TabContentBackground+ �� $ TemplatedParent=���5!   %   �� *TabContentBorderBrush+ �� $ TemplatedParent=���5"   %   �� *TabContentBorderThickness+ �� $ TemplatedParent=�._�5$   "   �� $��PART_SelectedContentHost��5(   3   #��z 5$   3   #��z 5%   3   # z 5&   3   $��SelectedContent��5'   3   # z 5)   3   $��2q�5*   3   5+      5,      5-       5.      P� 5/       �@��TabStripPlacement$ Bottom=�6J   . �50      �� $ TabPanelBorder��6%    � ��$ 1��6U   �� 51      $ TabPanelBorder��6%    � ��$ 0,0,0,0q�6d   �� 52      $ ContentPanel��6%    � ��$ 0��6S   �� 53      $
 Row0��6%    � ��$ * �6W   �� 54      $
 Row1��6%    � ��$
 Auto �6W   55      P� 56       �@��TabStripPlacement$
 Left=�6J   . �57      �� $ TabPanelBorder��6%    � ��$ 0��6U   �� 58      $ TabPanelBorder��6%    � ��$ 0,0,0,0q�6d   �� 59      $ TabPanelBorder��6%    � ��$ 0��6X   �� 5:      $ ContentPanel��6%    � ��$ 0��6S   �� 5;      $ ContentPanel��6%    � ��$ 1��6V   �� 5<      $
 Col0��6%    � ��$
 Auto �6Y   �� 5=      $
 Col1��6%    � ��$ * �6Y   �� 5>      $
 Row0��6%    � ��$ * �6W   �� 5?      $
 Row1��6%    � ��$ 0 �6W   5@      P� 5A       �@��TabStripPlacement$ Right=�6J   . �5B      �� $ TabPanelBorder��6%    � ��$ 0��6U   �� 5C      $ TabPanelBorder��6%    � ��$ 1��6X   �� 5D      $ TabPanelBorder��6%    � ��$ 0,0,0,0q�6d   �� 5E      $ ContentPanel��6%    � ��$ 0��6S   �� 5F      $ ContentPanel��6%    � ��$ 0��6V   �� 5G      $
 Col0��6%    � ��$ * �6Y   �� 5H      $
 Col1��6%    � ��$
 Auto �6Y   �� 5I      $
 Row0��6%    � ��$ * �6W   �� 5J      $
 Row1��6%    � ��$ 0 �6W   5K      P� 5L       � {�$ False��6A   . �5M      �� # � ��6G    � ��5N      5Q      5S       5T   
   ���� 5U      '��       " ��6   8   .�5V      ��  �@�OverridesDefaultStyle$
 True��6:   �� 5W       � �� 5X      �� 5Y      " ��6*   .R�5Z      � .+�5[   "   �� $��	TabBorder��6)   $��-1,0,0,0q�5]   )    5[   :   �� *TabItemCornerRadius+ �� $ FindAncestor=� local:CustomTabControl 5\   )   �� *	Padding+ �� *TemplatedParent+._�5^   &   � $��Panel��6+   .+�5_   *   �� $ ContentSite��6;   $��Center=�6P   $��Stretch=�5`   ;   $��Header��6Y   5a   '   5b   #   5c       5d      P� 5e   "    �@��
IsSelected$
 True��6@   . �5f   &   �� $ 	TabBorder��6-    6Z   �� *ActiveTabItemBackground+ �� $ FindAncestor=� local:CustomTabControl � ���� 5g   &    6C   �� *ActiveTabItemForeground+ �� $ FindAncestor=� local:CustomTabControl � ���� 5h   &   $ 	TabBorder��6-    6[   �� *ActiveTabItemBorderBrush+ �� $ FindAncestor=� local:CustomTabControl � ���� 5i   &   $ 	TabBorder��6-    6_   �� *ActiveTabItemBorderThickness+ �� $ FindAncestor=� local:CustomTabControl � ��5j   #   P� 5k   "    �@��
IsSelected$ False��6@   . �5l   &   �� $ 	TabBorder��6-    6Z   �� *TabItemBackground+ �� $ FindAncestor=� local:CustomTabControl � ���� 5m   &    6C   �� *TabItemForeground+ �� $ FindAncestor=� local:CustomTabControl � ���� 5n   &   $ 	TabBorder��6-    6[   �� *TabItemBorderBrush+ �� $ FindAncestor=� local:CustomTabControl � ���� 5o   &   $ 	TabBorder��6-    6_   �� *TabItemBorderThickness+ �� $ FindAncestor=� local:CustomTabControl � ��5p   #   ]� 5q   "    5r   &   �� 5s   *    �@��
IsSelected$  False��6J   �� 5t   *    �@J�IsMouseOver$
  True��6K   /�5v   &   �� 5w   *    �@�Cursor$
 Hand��6C   5y   #   5{      5}      5~      5      5�      5�      