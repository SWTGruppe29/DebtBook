   M S B A M L   `   `   `  ����C  ?DebtBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:DebtBook.ViewsDebtBook.Views  5   	       DebtBook.Views.DebtorView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:DebtBook.Views     5   	     � Title$  
View debts��5   	   $	��325��6   $	��300��6,   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $
��Auto �6   6.    � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   .+�5   
   �� $
��Bold"�6<   $��0��6N   $��0��6[   ��6   ��  �� Path$ CurrentDebtor.Name�6[   �� 5   
   $��0��5      $��1��5      $��5q�5      $��Stretch=�5      ��. $	��210��5      ��5      �� $ DebtAndDates���5      �� 5       .R�5!      ��  �� Orientation$ 
Horizontal=�6!   .+�5"      �� ��6$   �� $
 Debt��� 5#      $	�� - ��6$   �� 5$       J� Opacity$	 0.6Q�6$   ��62   �� $
 Date�5%      5&      5(      �� 5)   
   $��0��6   $��2��6%   $ 
Horizontal=�62   .+�5*      �� -   5        $��25��5*      $��45��6!   $��5q�6,   .��6R   Ok6V   �� 5+      $��25��6   $��45��6!   $��5q�6,    �� IsCancel . .��6H   Cancel6P   5,      �� 5.   
   $ Vertical=�6   $��1��6,   $��1��6<   .+�5/      �� $��60��6d   $��5q�6o   $��25��6z   ��6   �� $ Value� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 50      	 �� 	IsDefault	 . $��5q�6N   $��60��6Y   $��25��6d   ��6&   �� $ AddDebtCommand�.��6p   
Add debt6z   51      53      54      