   M S B A M L   `   `   `  ����F  Btopsecret_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:topsecret_1topsecret_1  5   	       topsecret_1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:topsecret_1     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$!  Детали массива��5	   	   $	��600��6    $
��1000��6-    � WindowStartupLocation$ CenterScreen=�6:   .��5
      � ���	#ffdadada.+�5   
   �� $	��500��6   $��15q�6    ���#fff$��Center=�6>    �� Padding$ 30q�6Y   $	��800��6f    �� CornerRadius$ 20��6u    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      Color$ 	LightGray��63      ShadowDepth$ 0Q�6E   ._�5      �� .+�5      �� $��Здравствуйте!��6   $��30(�61   $
��Bold"�6?   �� 5      -   5         ��Name$ LengthOfArray��5      )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$K	 EВведите количество элементов массива��61    %  !MaterialDesignFloatingHintTextBox#��[  6w   �� 5      -   5        $��Подтвердить��5      $��Stretch=�6/   6M   �� 5      $
��Left=�6   $��	10 10 0 5q�67   $
��Bold"�6J   $:��4Созданные элементы массива: ��6\   �� 5      $
��Auto=�6   $
��Auto=�6B   .��5      �� .+�5      �� -   5        
 ��Name$
 ArrayValues��5   $   $��70��6:   $��WrapWithOverflow=�6I   5      5      �� 5      .+�5      �� $
��Left=�6    $��	10 10 0 0q�6;   $
��Bold"�6N   $.��(Максимальный элемент:��6`   �� 5      -   5        $
 	MaxResult��5       $
��Left=�64   $��	10 10 0 0q�6O   $	��100��6b   5      �� 5!      .+�5"      �� $
��Left=�6    $��	10 10 0 0q�6;   $
��Bold"�6N   $,��&Минимальный элемент:��6`   �� 5#      -   5        $
 	MinResult��5#       $
��Left=�64   $��	10 10 0 0q�6O   $	��100��6c   5$      �� 5&      .+�5'      �� $
��Left=�6    $��	10 10 0 0q�6;   $
��Bold"�6N   $'��!Среднее значение: ��6`   �� 5(      -   5        $
 AverageResult��5(       $
��Left=�68   $��	10 10 0 0q�6S   $	��100��6f   5)      �� 5+      .+�5,      �� $
��Left=�6    $��	10 10 0 0q�6;   $
��Bold"�6N   $%��Сумма элементов: ��6`   �� 5-      -   5        $
 	SumResult��5-       $
��Left=�64   $��	10 10 0 0q�6O   $	��100��6b   5.      �� 50      $
��Left=�6   $��	10 10 0 0q�67   $
��Bold"�6J   $#��Нечетные числа: ��6\   �� 51      $
��Auto=�6   $
��Auto=�6B   .��52      �� .+�53      �� -   5        $
 	OddValues��53   $   $��70��68   $��WrapWithOverflow=�6G   54      55      56      57      58      59      