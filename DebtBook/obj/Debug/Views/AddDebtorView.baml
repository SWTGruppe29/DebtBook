   M S B A M L   `   `   `  ����C  ?DebtBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:DebtBook.ViewsDebtBook.Views  5   	   9!clr-namespace:DebtBook.ViewModelsDebtBook.ViewModels  5   	   "    DebtBook.Views.AddDebtorView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:DebtBook.Views     5   	   0vm!clr-namespace:DebtBook.ViewModels     5   	     � WindowStartupLocation$  CenterOwner=�5	   	    � ShowInTaskbar .   � Title$ 
Add Debtor��5   	   $��135.046��6   $��242.289��6-    � 
ResizeMode$ NoResize=�6=   .��5      �  � ColumnDefinitions 5   
   �� 5      $��45 �6   �� 5      $	��180 �6    � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $��40 �6   .+�5   
   �� $	��0,5q�6   $��0��6#   $��0��63   .+�5      �� .��6   Name:6   �� 5      .��6   Value:6   5      �� 5   
   $	��0,5q�6   $��1��6"   $��0��62   .+�5      �� $��5q�6   ��6!   ��  �� Path$ CurrentDebtor.Name�6L   �� 5      $��5q�6   ��6!   �� $ CurrentDebtor.Debt�6L   5      �� 5    
   -   5         ��Name$ AddBtn��5        �� 	IsDefault . $
��_Add��62   $��1��6A   $
��Left=�6Q   $��	9.4,5,0,0q�6l   $��1��6   $	��Top=�6�   $��75��6�   6�   �� 5!   
   $��_Cancel��6   $��1��6#   	 �� IsCancel	 . $
��Left=�6C   $��	100,5,0,0q�6^   $��1��6q   $	��Top=�6~   $��75��6�   5#      5$      