   M S B A M L   `   `   `  ����G  CTabControlEx, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:TabControlExTabControlEx  5   	       TabControlEx.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:TabControlEx     5   	     � Title$  TabControl 예제��5   	   $	��200��6   $	��250��6,   .��5	      � 
������� � RowDefinitions 5
      �� 5      �� 5      $
��Auto �6   .+�5   
   �� $��5 5 5 0q�6    �� TabStripPlacement$ Bottom=�6&   .@�5      �� $��사원��6   .��5      � $��Center=�6    � ColumnDefinitions 5      �� 5      $
��Auto �6+   �� 5       5      �� 5      $
��Auto �6(   �� 5      $
��Auto �6(   .+�5      �� $��5q�6   .��6'   부서6+   �� 5      $��1��6   $��5q�6.   �� 5      $��5q�6   $��1��6'   .��64   이름68   �� 5      $��1��6   $��1��6+   $��5q�6;   5      5      �� 5      $��급여��6    �� 
IsSelected . .��5       � $��Center=�6    5!      �� 5"      $
��Auto �6+   �� 5#       5%      �� 5&      $
��Auto �6(   �� 5'      $
��Auto �6(   .+�5)      �� $��5q�6   .��6'   분류6+   �� 5*      $��5q�6   $��1��6*   @�5+      �� 5,      .��6+   연봉6/   �� 5-      .��6+   월급6/   5/      �� 50      $��5q�6   $��1��6'   .��64   금액68   �� 51      $��1��6   $��1��6+   $��5q�6;   52      53      54      �� 55   
    �� Orientation$ 
Horizontal=�6   $��1��6.   $��Center=�6;   .+�56      �� $	��100��6   $
��5 10q�6!   $��확인��6/   �� 57      $	��100��6   $
��5 10q�6!   $��취소��6/   59      5:      5;      