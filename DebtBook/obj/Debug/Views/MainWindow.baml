   M S B A M L   `   `   `  ����C  ?DebtBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DebtBookDebtBook  5   	   9!clr-namespace:DebtBook.ViewModelsDebtBook.ViewModels  5   	       DebtBook.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:DebtBook     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   1	viewModel!clr-namespace:DebtBook.ViewModels  5   	     � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6)    � 
ResizeMode$ NoResize=�5   	    � DataContext 5      -   'DebtBook.ViewModels.MainWindowViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��41 �6   6*   �� 5      $
��Auto �6   $	��378��6*   6<    � ColumnDefinitions 5   
   �� 5      $	��600 �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��0��6    $��0q�6-   $��Center=�68   $��20(�6V   .��6d   Debtors/Creditors6w   �� 5   
   $��1��6   $��1��6!   $��5.2,0,-102.4,339q�6.   $��40��6H   $��Bottom=�6T   $
��Bold"�6�   $��Dubai Medium)�6�   ��6o   ��  �� Path$ AddDebtorCommand�.��6�   Add6�   �� 5    
   $��1��6   $��1��6!   $��5,45,-102,294q�6.   $��40��6E   ��6Q   �� $ ViewDebtorCommand� �� UpdateSourceTrigger$ PropertyChanged=�.��6�   View6�   &   System.Windows.Controls.DataGrid  5"   
   -   5        $��DataGridDebtors��50      $��1��5"      $��0��6    $	��Top=�60   $��Center=�6H   $	��275��6e   $	��368��6u   $	��510��6�   $��	51,0,50,0q�6�   $ �� IsSynchronizedWithCurrentItem$
 TrueY�5'         CanUserAddRows .  	   CanUserDeleteRows	 .  
   CanUserResizeRows
 .     CanUserResizeColumns .     CanUserReorderColumns .     CanUserSortColumns .     MinColumnWidth$	 250Q�5.         
IsReadOnly .    AutoGenerateColumns .  ��5#      �� $ Debtors� �� SelectedItem 5%      �� $ CurrentDebtor� �� SelectedIndex 5&      �� $ CurrentIndex�   Columns 53      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� $
 Name�  55      $
 Debt��56       6%   �� $
 Debt�5:      5<      5=      