   M S B A M L   `   `   `  ����H  DParkingSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ParkingSystemParkingSystem  5          ParkingSystem.Vehicle_In   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:ParkingSystem     5      .��5	      � ��5   
   �� 5        �� ImageSource$  vehicle In.jpg��6    j� Stretch$
 Fill=�66   .+�5   
   (  "System.Windows.Controls.DatePicker  $��30��6   $	��200��6!   $��Center=�6-   $��Center=�6J   $��29,84,571,336q�6e   �� 5   
   $��iSprout��6   $��Center=�6"   $	��200��6?   $��70��6K   $��288,10,312,370q�6W   $��Segoe UI Black)�6o   $��48(�6�   ���	#FFFF62006�   �� 5   
   $��   Token No:��6   $��Center=�6'   $��80��6D   $��30��6O   $��29,133,691,287q�6[   ���	#FFFBF8F8$
��Bold"�6�   �� 5   
   $�� Vehicle Mode:��6   $��Center=�6)   $	��110��6F   $��30��6R   $��29,173,661,247q�6^   ���	#FFFBF8F8$
��Bold"�6�   �� 5   
   $��   Vehicle No:��6   $��Center=�6)   $	��110��6F   $��30��6R   $��29,203,661,217q�6^   ���	#FFFBF8F8$
��Bold"�6�   �� 5   
   $��	   Brand:��6   $��Center=�6$   $��80��6A   $��30��6L   $��49,243,671,177q�6X    J� RenderTransformOrigin$ 
0.892,1.01&�6p   ���	#FFFBF8F8$
��Bold"�6�   �� 5   
   $��	   Color:��6   $��Center=�6$   $	��100��6A   $��30��6M   $��59,273,641,147q�6Y   ���	#FFFBF8F8$
��Bold"�6�   �� 5   
   $��
  Time IN:��6   $��Center=�6%   $��80��6B   $��30��6M   $��49,308,671,112q�6Y   ���	#FFFBF8F8$
��Bold"�6�   $ 0.875,0.467&�6�   �� 5   
   -   5         ��Name$
 txt3��5      $��Center=�6    $��30��6=   $��90��6I   $��129,133,581,287q�6T   6�   �� 5   
   -   5        $
 txt4��5      $��Center=�6    $��30��6=   $��90��6I   $��129,203,581,217q�6T   6o   �� 5   
   -   5        $
 txt5��5      $��Center=�6    $��30��6=   $��90��6I   $��129,238,581,182q�6T   $ 	0.83,-0.4&�6m   6�   �� 5   
   -   5        $
 txt6��5      $��Center=�6    $��30��6=   $��90��6I   $��129,273,581,147q�6T   $ 0.725,1.801&�6m   6�   �� 5!   
   -   5        $
��cbm1��5!      $��90��6   $��30��6*   $��Center=�66   $��129,168,581,252q�6S   6n   �� 5#   
   -   5         ��Name$
 bnt1��5#      $��Vehicle��6   $��Center=�61   $	��100��6N   $��30��6Z   $��129,371,571,49q�6f   ���	#FF41C1166�   �� 5$   
   -   5        $
 bnt2��5$      $��Delete��6   $��Center=�60   $	��100��6M   $��30��6Y   $��306,371,394,49q�6e   ���	#FFE6482F6�   �� 5%   
   -   5        $
 bnt3��5%      $
��Save��6   $��Center=�6.   $	��100��6K   $��30��6W   $��485,371,215,49q�6c   ���	#FFF9F9F9$ 1.42,0.6&�6�   6�   �� 5&   
   -	   5        $
 bnt4��5&      $
��Back��6   $��Center=�6.   $	��100��6K   $��30��6W   $��650,371,50,49q�6c   ���	#FF42403E
�������6�   �� 5*   
   $��266,115,105,111q�6   ���	#FFBEC3C7.+�5+      &   System.Windows.Controls.DataGrid     AutoGenerateColumns .    Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   Header$ Token No��6)     5.      $ Vehicle Mode��6)     5/      $ 
Vehicle No��6)   4  .System.Windows.Controls.DataGridCheckBoxColumn  50      $ Brand��6-     51      $ Color��6-     52      $ Time in��6-   54      55      57      58      