   M S B A M L   `   `   `  ����G  CMyWpfProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MyWpfProjectMyWpfProject  5   	       MyWpfProject.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:MyWpfProject     5   	     � Title$   STM32 MCU Simple Navigator��5   	   $	��500��6,   $	��700��69   .��5	      � $��20q�6    � RowDefinitions 5
   
   �� 5      $��50 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $	��150 �6   �� 5      $	��150 �6   �� 5      $	��150 �6   �� 5      $
��Auto �6   .+�5   
   �� $ ��STM32 MCU Simple Navigator��6   $��Center=�65   $��Center=�6R   $��20(�6m   $��0��6{   $��0��6�   �� 5   
   $L��FC:\Users\shichen.hong\Documents\GitHub\MyWpfProject\resources\pic1.png��6   $��0��6`   $��2��6m   �� 5   
   $��10q�6   $
��Wrap=�6    $��1��64   $��0��6A   �� 5      -   5        $^��Xhttps://www.st.com/en/microcontrollers-microprocessors/stm32-32-bit-arm-cortex-mcus.html?�5      .�5   9   Link to stm32 mcu home page5!      5"      �� 5#   
   $��2��6   $��0��6!   $��10q�61   Group5%      �� 5&   
   $��2��6   $��1��6!   $��10q�61   Series5(      �� 5)   
   $��2��6   $��2��6!   $��10q�61   Type5+      �� 5,   
   -   5        $��lb_Group��5,   /   $��4��6   $��0��6    �� SelectionMode$ Extended=�6?   
����  �.@�5-      �� .��6   High Performance6#   �� 5.      .��6   
Mainstream6   �� 5/      .��6   Ultra Low Power6"   50      �� 51   
   -   5        $��	lb_Series��51   /   $��4��6   $��1��6   $ Extended=�6@   
����  �52      �� 53   
   -   5        $��lb_Type��53   /   $��4��6   $��2��6   $ Extended=�6>   
���  ��54      �� 56   
   -   5        $��bt_Start��56      $��Start��6!   $��10q�61   $��6��6=   $��0��6J   $��12(�6Z   $��40��6�   $	��100��6�   ${�false��6�   �� 57   
   -   5        $��bt_Clear��57      $��Clear��6!   $��10q�61   $��6��6=   $��1��6J   $��12(�6Z   $��40��6�   $	��100��6�   ${�false��6�   58      59      