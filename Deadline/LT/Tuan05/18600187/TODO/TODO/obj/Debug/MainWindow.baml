   M S B A M L   `   `   `  ����?  ;TODO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TODOTODO  5   	       TODO.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:TODO     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.2.1465, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          � Title$
  TODO��5	   	    � Icon$ todo.png��6   $	��800��6&   $	��800��63    � WindowStartupLocation$ CenterScreen=�6?    � WindowStyle$
 None=�6d    � 
ResizeMode$ NoResize=�6w   $��Segoe UI Emoji)�6�   .��5
      � .+�5   
   �� $��	TODO LIST��6   $��72(�6$   $��0q�62   $
��Bold"�6=   $��Center=�6O   $	��Top=�6l   ���	#FF673AB76�   �� 5   
   -   5        $��newDataTextBox��5       *  &MaterialDesignOutlinedTextFieldTextBox#��[  6(   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Enter Task��6h   $��20,120,230,60q�6�   $	��Top=�6�   $��Champagne & Limousines)�6�   $��18(�6�    �� 
CaretBrush �	#FF7F5DFF �� SelectionBrush �	#FF7F5DFF
����������	#FF7F5DFF K� ZIndex$ 1��6U  �� 5   
   -   5        $	��Add��5      	 �� 	IsDefault	 . $
��Left=�6H   $��482,125,0,0q�6c   $	��Top=�6x   $��70��6�   $��18(�6�   $ 1��6�   �� 5   
   -   5        $��Delete��5      $��90��6=   $��18(�6H   $��Center=�6V   $��Right=�6z   $��Center=�6�   $��0,0,20,0q�6�   $ 1��6�   �� 5   
    - )MaterialDesignToolBarMainPanelBorderStyle#��[ 6   $��600,120,20,60q�6T   $	��Top=�6k   $��40��6�   $ 1��6�   6�   �� 5   
   $��600,120,20,550q�6   .+�5      �� $
��43.2��6   $��18(�5   x   ���	#FF673BB5$ 1��6�   -  'MaterialDesignThemes.Wpf.ComboBoxAssist
   ClassicMode
 6   ��  �� ElementName$ ClassicModeCheckBox�� �� Path$ 	IsChecked�.@�5      ��  �� 
IsSelected . .��61   All5      �� 5      .��6   	Completed5      �� 5      .��6   Umcompleted5      5      5      �� 5   
   $��20,200,20,20q�6   ._�5      �� -   5        $��todoListBox��5      ���	#FF673AB7���	#FF673AB7$��18(�6X   $��100,0q�6f   5!      5"      5#      5$      