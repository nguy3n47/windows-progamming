   M S B A M L   `   `   `  ����?  ;BT01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BT01BT01  5   	       BT01.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:BT01     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Login��5	   	   $	��500��6   $	��350��6$    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   $��Segoe UI Emoji)�5   	   .��5      � .+�5   
   �� $	��280��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ #481380��6#   � 5      $ #fff0f5��6#    � Offset$ 1Q�63   � 5      $ #efb1ff��6#   $ 0.546Q�63   5      5      �� 5   
   $	��280��6   $	��240��6    $��Bottom=�6-   $
��0,80q�6H    �� RadiusY$ 10��6V   	 �� RadiusX$	 10��6c   
�������
 J� Effect
 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 15Q�6#      	Direction$ 0Q�63      RenderingBias$ Quality=�6A      ShadowDepth$ 1Q�6Y      Color$ 	#FF7F5DFF��6i   5      � 5   
   $��Bottom=�6   $��35,80q�6*   $	��240��69   .+�5      �� $��LOGIN��6   $��Center=�6$   $	��Top=�6A   $��25q�6Y   ���	#FF7F5DFF$��18(�6|   �� 5       $��Center=�6   $��15q�64   .+�5!      �� $��_U��6   $��0��6c   $��0��6m    �� Target 6%   ��  �� ElementName$ Username����6M   Z� 6z   �� 5"      -   5        $��Username��5"      $
��0,10q�6*   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Username��68    %  !MaterialDesignFloatingHintTextBox#��[  6c   $��Champagne & Limousines)�6�   $��16(�6�    �� 
CaretBrush �	#FF7F5DFF �� SelectionBrush �	#FF7F5DFF
����������	#FF7F5DFF
������ 60  �� 5#      $��_P��6   $��0��6c   $��0��6m    6%   �� $ Password����6M   Z� 6z   G� 5$      -   5        $��Password��5$      $
��0,10q�6.   $ Password��6<    ) %MaterialDesignFloatingHintPasswordBox#��[ 6f   $��Champagne & Limousines)�6�   $��16(�6�   
������� G� 
CaretBrush �	#FF7F5DFF G� SelectionBrush �	#FF7F5DFF���	#FF7F5DFF69  5%      5&      �� 5'   
   -   5        $	��150��5'   +   $��Center=�67   $��Bottom=�6T   $
��0,65q�6o   $��LOGIN��6}   ���	#FF7F5DFF6�   �� 5(   
   $��FORGOT PASSWORD?��6   $��Center=�6,   $��Bottom=�6I   $��30q�6d   ���	#FF7F5DFF � Cursor$
 Hand��6�   �� 5)   
   $J��Dhttps://pngimage.net/wp-content/uploads/2018/06/logo-login-png-5.png��6    �� BitmapScalingMode$ HighQuality=�6^   $	��100��6�   $	��100��6�   $	��Top=�6�   $��30q�6�   5*      5+      