   M S B A M L   `   `   `  ����E  AWpfMvvmUA2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WpfMvvmUA2
WpfMvvmUA2  5   	   E'clr-namespace:WpfMvvmUA2.Views.ControlsWpfMvvmUA2.Views.Controls  5   	       WpfMvvmUA2.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WpfMvvmUA2     5   	   <controls'clr-namespace:WpfMvvmUA2.Views.Controls     5   	     � Title$  
MainWindow��5	   	   $	��600��6   $
��1000��6)   ���#F2F2F2.��5
      �  � Cursor$  ��6    � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      .+�5   
   � $��0��6   
������  � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $��* �6    .+�5      ��  �� Orientation$ 
Horizontal=�6   $��0��62   $��10q�6?   .+�5      F�  �� Stretch$ Uniform=�6   ���#504BD7$��5q�68   $��40��6C   $��40��6O      Logo#��[  6Z   �� 5      $��Project Tracker��6   $��18(�63   ���#504BD7$��Center=�6V   $
��Bold"�6q   5      �� 5      $��1��6   ���#504BD7 �� CornerRadius$ 0,50,0,0��67   $��Stretch=�6O   $��Stretch=�6k   ._�5      �  5       �� 5!      �� 5"      $��80 �6(   .+�5$      �� -   5         ��Name$ sidebar��5$   n   $��0��6    �� SelectionMode$ Single=�6+   $��0q�6   $��
10,50,10,5q�6�   
������ $	��400��6�   .@�5%      )   #WpfMvvmUA2.Views.Controls.NavButton  	   Navlink$	 /Views/Projets.xaml?�6-   $��8q�6K   $��6q�6V   
   NavTitle$
 Projets��6b     ProjetsIcon   Icon# [ 6u     5&      $	 /Views/Membres.xaml?�6-   $��8q�6K   $��6q�6V   $
 Membres��6b     MembresIcon# [ 6u     5'      $	 /Views/Affectation.xaml?�6-   $��8q�6O   $��6q�6Z   $
 Affectations��6f     AffectationIcon# [ 6~   5(      �� 5*      -   5        $��1��5*        ActionButtonStyle#��[ 6*   $��30��6a   $	��100��6m   $��
8,10,10,10q�6y   $	��Top=�5+      $
��Left=�61   
�������
������ 
������ $
 Hand��6�   .��5-      �� $ 
Horizontal=�6%   .+�5.      F�   	CloseIcon#��[ 6#   $��20��6E   $��20��6Q   $��5q�6\   
�������$ Uniform=�6t   $��Center=�6�   �� 5/      $��Quitter��6$   
�������$��Medium"�6I   50      51      52      53      54       � 57   
   -   5          �Name$ navframe��57   -   $��1��6   $��10q�6      � NavigationUIVisibility$ Hidden=�6?   ���#F2F2F26_   58      59      