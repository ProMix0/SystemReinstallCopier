   M S B A M L   `   `   `  ����P  LSystemReinstallCopier, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SystemReinstallCopierSystemReinstallCopier  5   	   &     SystemReinstallCopier.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:SystemReinstallCopier     5   	   -   5          �Name$  window��5	   	    � Title$ 
MainWindow��5   	   $	��450��6   $	��800��6)    � DataContext 5
   	   ��  �� ElementName$ window�� �� Path$ 	ViewModel�.��5      ]� $
��True��6   .+�5   
   o� $	��Top=�6   .@�5      m� $��Файл��6   .@�5      m� $��Сохранить��6   m� 5      $��Сохранить как��6   m� 5      $��Загрузить��6   5      5      �� 5   
   $	��Top=�6   $��10q�6*   .+�5      �� $9��3Папка для сохранения файлов��6   �� 5      -   5         ��Name$ saveFolderText��5       �� TextWrapping$
 Wrap=�6J   $��0,5,0,5q�6^   ��6.   �� *
SaveFolder+6^   �� 5      -   5        $��Выбрать папку��5      $
��Left=�6-   6H   5      � 5   
   $��Bottom=�6    � ColumnDefinitions 5      �� 5      �� 5      .+�5       �� $��Создать копию��6   $��0��6-   $��5q�6=   �� 5!      $)��#Восстановить копию��6   $��1��62   $��5q�6B   5"      �� 5$   
   $��10q�6    �� CanHorizontallyScroll$ False��6!   .+�5%      �� $H��BДобавить папку в список сохраняемых��6   �� 5&      -   5        	 ��Name$	 listView��5&      $��0,5,0,5q�6d   ��6(   �� $$ Configuration.SavedDirectories���5'      �� 5(      .R�5)      � 
 � RowDefinitions
 5*      �� 5+   "   $��* �60    5-      �� 5.   "   �� 5/   "   .+�52      �� $��0��6%   $
��Abcd��65   �� 53      $��1��6(   $
��Wrap=�6W   $��Center=�6k   ��68   �� $ FullName�6k   55      56      58      59      5:      5;      