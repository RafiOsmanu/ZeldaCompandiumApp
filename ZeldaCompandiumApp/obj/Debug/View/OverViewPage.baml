   M S B A M L   `   `   `  ����M  IZeldaCompandiumApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:ZeldaCompandiumApp.ViewZeldaCompandiumApp.View  5      K*clr-namespace:ZeldaCompandiumApp.ViewModelZeldaCompandiumApp.ViewModel  5      M+clr-namespace:ZeldaCompandiumApp.ConvertersZeldaCompandiumApp.Converters  5      *    $ZeldaCompandiumApp.View.OverViewPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:ZeldaCompandiumApp.View     5      9vm*clr-namespace:ZeldaCompandiumApp.ViewModel     5      A	converter+clr-namespace:ZeldaCompandiumApp.Converters     5        N� Title$  OverViewPage��5       � DataContext 5      1  +ZeldaCompandiumApp.ViewModel.OverViewPageVM  5   
    � 	Resources 5      .  (ZeldaCompandiumApp.Converters.UrlToImage   
UrlToImage  SheikahBlue �� Color  RobotoMedium��%�   &	        &	      &	 4       5   
   6   �� 5   
   $ #40d4fc��6.   *�5   
   A=/ZeldaCompandiumApp;components/Resources/Fonts/#Roboto Medium)�6i   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��1.2* �6   �� 5      $��3* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5       $��* �6   �� 5!      $	��12* �6   �� 5"      $��* �6   .+�5'   
   �� $7��1pack://application:,,,/Resources\Bg\BgPattern.png��6   $��UniformToFill=�6K   $��3��6c   $��4��6t   �� 5(   
   $=��7pack://application:,,,/Resources\Overlays\ScanLines.png��6   $��UniformToFill=�6Q    J� Opacity$	 0.2Q�6i   $��3��6w   $��4��6�   �� 5*   
   $9��3pack://application:,,,/Resources\Overlays\Glow0.png��6   $��Uniform=�6M   $��Bottom=�6_   $��	0,0,0,-30q�6z   $	 0.6Q�6�   $��3��6�   $��4��6�   �� 5+   
   $9��3pack://application:,,,/Resources\Overlays\Glow1.png��6   $��Uniform=�6M   $	��Top=�6_   $��	0,-15,0,0q�6w   $	 0.6Q�6�   $��3��6�   $��4��6�   �� 5,   
   $D��>pack://application:,,,/Resources\Overlays\ShekiahMapBorder.png��6   $
��Fill=�6X   $��3��6g   $��4��6x   �� 5.   
   $��Center=�6   $��64��6,   $��16��67   
������ $��0q�6\   $
��Left=�6p   #��[ 5/      $��10, 34, 0, 0q�50      $��1��6'   $��3��67   ��51      �� *
SwitchJson+��52      �� *CommandText+ J� Effect 54      3  -System.Windows.Media.Effects.DropShadowEffect  55         
BlurRadius$ 8Q�6e   	   ShadowDepth$	 0Q�6t   
   Opacity$
 1Q�6�      Color 6#   ��  �� Source# [  �� Path$ Color�6�   58      �� 5;   
   $��0, 25, 0, 0q�5<      $	��685��5=   
   $	��280��6   $��0q�6#   $��6��5>   
   $��4��6   
������  �� SelectionMode$ Single=�5?   
   ��5;      �� *
Monsters+ �� SelectedItem 63   �� *SelectedMonster+��5@      �� 5A      .R�5B      A�  A� Rows$ 3��6"    A� Columns$ 8��6+   5C      ��5E      �� 5F      .R�5G      �  5H      �� 5I      $
��Auto �6,   �� 5J      $
��Auto �6,   .+�5L      �� 
�������$	��0.8q�65   $��70��6K   $��70��6V    5N        5O   "   $ 	AliceBlue��63   $ 5Q�6E   $	 0Q�6T   $
 1Q�6d   ._�5Q      �� $��Uniform=�6d   $��70��6v   $��70��6�   $��0��6�   ��6$   �� *Image+ �� 	Converter# [  6�   5R      �� 5T      $>��8pack://application:,,,/Resources\Overlays\ImageFrame.png��6    $��0��6b   $��74��6o   $��74��6{    5U        5V   "   $ 5Q�6u   $	 0Q�6�   $
 1Q�6�    63   �� # [ $ Color�6�   5X      �� 5Z      #��[ 6:   #��[ 6d   $��8(�6�   $��Italic$�6�   $��1��6�   $��1��6�   $��Center=�6�   $��
0, 2, 0, 0q�6�   ��6$   �� *Name+ 5[        5\   "   $ 8Q�6u   $	 0Q�6�   $
 1Q�6�    63   �� # [ $ Color�6�   5^      �� 5`      #��[ 6:   #��[ 6d   $��8(�6�   $��Italic$�6�   $��1��6�   $��1��6�   $
��Left=�6�   $��4.5, -12, 0, 0q�6�   ��6$   �� *Numb+ 5a        5b   "   $ Black��63   $ 5Q�6A   $	 0Q�6P   $
 1Q�6`   5e      5h      5i      5k      � 5o   
   $��0��6   $��1��6    5p      �� 5q      $��* �6    �� 5r      $
��1.7* �6     5t      �� 5u      $��* �6#   �� 5v      $��* �6#   �� 5w      $��* �6#   .+�5z      �� $h��bC:\DAE\DAE_ToolDev_22-23\ZeldaCompandiumApp\ZeldaCompandiumApp\Resources\Details\MaterialIcon1.png��6   $��20��5{      $��20��6   $��1��5|      $��1��6!   $	��Top=�5}      $��0, 18, 0, 0q�6,    5~        5      $ 8Q�6i   $	 0Q�6x   $
 1Q�6�    6'   �� # [ $ Color�6�   5�      �� 5�      $h��bC:\DAE\DAE_ToolDev_22-23\ZeldaCompandiumApp\ZeldaCompandiumApp\Resources\Details\PageIndecator.png��6   $��7��5�      $��7��6   $��1��5�      $��1��6!   $	��Top=�5�      $��0, 12, 0, 0q�6,    J� RenderTransformOrigin$ 0.5,0.5&�6A    5�        5�      $ 8Q�6i   $	 0Q�6x   $
 1Q�6�    6'   �� # [ $ Color�6�   5�      �� 5�      $��Monsters��6   #��[ 6(   #��[ 6R   $��10(�6}   $��Italic$�6�   $��1��6�   $��1��6�   $	��Top=�6�   $��Center=�6�    5�        5�      $ 8Q�6i   $	 0Q�6x   $
 1Q�6�    6'   �� # [ $ Color�6�   5�      �� 5�      $��Hyrule Compandium��6   #��[ 61   #��[ 6[   $��13(�6�   $��Italic$�6�   $��1��6�   $��0��6�   $��Center=�6�   $��Center=�6�   $��0, 10, 0, 0q�6�    5�        5�      $ 8Q�6i   $	 0Q�6x   $
 1Q�6�    6'   �� # [ $ Color�6�   5�      5�      5�      5�      