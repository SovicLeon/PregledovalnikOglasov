   M S B A M L   `   `   `  ����Q  MPregledovalnikOglasov1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:PregledovalnikOglasov1PregledovalnikOglasov1  5   	   '    !PregledovalnikOglasov1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:PregledovalnikOglasov1     5   	     � Title$  Avto oglasi��5   	   $	��450��6   $	��800��6*    � 	Resources 5
      ,   &PregledovalnikOglasov1.IsNullConverter   IsNullConverter��%   &	          5   
   6    5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��350 �6   �� 5      $��* �6   .+�5   
   �� $��Stretch=�6   ���	#FF062F57$��0��6J   $��3��6W   .+�5      �� $��Avto Oglasi��6   $��Center=�6*   
�������$��20(�6Z   $��Arial Black)�6h   5      �� 5   
   $��Stretch=�6    �� Orientation$ Vertical=�63   $��1��6J   $��1��6W   .+�5      o� $
��Auto��6   $��20(�6!   $��Stretch=�6/   .@�5      m� $��Datoteka��6   .@�5      m� -   5        $��Izhod��5       m� Icon 5       �� 5!      $7��1/4781838_cancel_close_delete_exit_logout_icon.png��6$   5#      m� 5$      -   5        $��Uvozi��5$       5%      �� 5&      $(��"/icons8-downloading-updates-24.png��6$   5(      m� 5)      -   5        $��Izvozi��5)       5*      �� 5+      $��/icons8-upload-24.png��6$   5-      5.      m� 5/      $��Oglasi��6   .@�50      m� -   5        $��Dodaj��50       51      �� 52      $#��/134224_add_plus_new_icon.png��6$   54      m� 55      -   5        $��Odstrani��55       56      �� 57      $��/352303_delete_icon.png��6$   59      m� 5:      -   5        $��Uredi��5:       5;      �� 5<      $4��./1564503_add_business_edit_editor_new_icon.png��6$   5>      5?      m� 5@      $��Orodja��6   .@�5A      m� -   5        $��Settings��5A   3   $��
Nastavitve��6    5B      �� 5C      $��/3671915_wrench_icon.png��6$   5E      5F      5G      #   PregledovalnikOglasov1.Filter  5H      5I      �� 5J   
   $��2��6   $��1��6$   $��Stretch=�64   .��5K      �� -   5        $��listView��5K   <   $��Stretch=�6   ��6}   �� *SourceCollection+��5L      �� 5M      .R�5N      �� {�.  .��5O      �� $ 
Horizontal=�6)   .+�5P   "   �� $��5q�6D   $	��150��6O   $	��200��6\   ��6(   �� *
ImageSrc+��5Q   &   �� 5R   *    �� 
TargetType" ��60    �� Triggers 5S   .   �� 5T   2    �� Binding 6>   �� *
ImageSrc+	 �� Value	 abc6[   .a�5U   6   �� 
 �� Property
 � �� �� Value$ /Citroen.jpg��6O   5V   3   5X   +   5Z   #   �� 5[   "   $ Vertical=�6-   $��5q�6D   $	��250��6O   .+�5\   &   �� $��Center=�6,   $��20(�6a   $
��Bold"�6o   ��6G   �� *Brand+6o   �� 5]   &   $ 
Horizontal=�61   .+�5^   *   �� $��Center=�60   $��Letnik: ��6K   $��18(�6^   �� 5_   *   $��Center=�60   $��18(�6d   ��6K   �� *Year+6d   5`   '   �� 5a   &   $ 
Horizontal=�61   .+�5b   *   �� $��Center=�60   $��Prevoženih km: ��6K   $��18(�6e   �� 5c   *   $��Center=�60   $��18(�6h   ��6K   �� *
Distance+6h   5d   '   �� 5e   &   $ 
Horizontal=�61   .+�5f   *   �� $��Center=�60   $��Gorivo: ��6K   $��18(�6^   �� 5g   *   $��Center=�60   $��18(�6d   ��6K   �� *Fuel+6d   5h   '   5i   #   �� 5j   "   $��5q�6-   .+�5k   &   �� $ 
Horizontal=�61   .+�5l   *   �� $��Center=�60   $��20(�6e   $
��Bold"�6s   ��6K   �� *Price+6s   �� 5m   *   $��Center=�60   $	��€��6K   $��20(�6W   $
��Bold"�6e   5n   '   �� 5o   &   $��Center=�60   $��18(�6K   ��6Y   �� *	Details+5p   #   5q      5r      5s      5u      5v      5w      5x      