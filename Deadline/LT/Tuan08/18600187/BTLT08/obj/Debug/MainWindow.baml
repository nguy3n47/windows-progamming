   M S B A M L   `   `   `  ����A  =BTLT08, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BTLT08BTLT08  5   	       BTLT08.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:BTLT08     5   	   -   5          � Title$  
MainWindow��5   	   $	��720��6   $
��1280��6)    � WindowStartupLocation$ CenterScreen=�6M   .��5	      ]� ��. .+�5
   
   o� $	��Top=�6   .@�5      m� -   5        $
��File��5      .@�5      m� $	��Add��6   5      m� 5      -   5        $
��Edit��5      6%   m� 5      -   5        $��Delete��5      6'   5      �� 5   
   $	��100��6   
��� ���67   � 5   
   -   5        $��parent��5   !   
����  �.+�5      �� -   5        $��dataListview��5      
�������$��Disabled=�6>   ��5      �� 5      .R�5      � 6&   5      ��5      �� 5      .R�5      ��  � ContextMenu 5      �� 5   "   .@�5   &   m� -   5        $
��Edit��5   /   6Z   m� 5   &   -   5        $��Delete��5   /   6^   5    #   .+�5"      ��  �� BitmapScalingMode$ HighQuality=�6n   $��90��6�   $��90��6�   ��6$   �� *	Picture+   imagePathConverter �� 	Converter# [  6�   �� 5#       �� ContentStringFormat$ Tên điện thoại: {0}��6$   ��6N   �� *Name+6i   �� 5$      $ Hãng sản xuất: {0}��6$   ��6M   �� *Manufacturer+6p   �� 5%      $ 	Giá: {0}��6$   ��6C   �� *Prices+6`   5&      5'      5)      5*      5+      5,      