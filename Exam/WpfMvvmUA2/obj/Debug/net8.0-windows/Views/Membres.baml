   M S B A M L   `   `   `  ����E  AWpfMvvmUA2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WpfMvvmUA2.ViewsWpfMvvmUA2.Views  5      ;"clr-namespace:WpfMvvmUA2.ViewModelWpfMvvmUA2.ViewModel  5          WpfMvvmUA2.Views.Membres   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      0localclr-namespace:WpfMvvmUA2.Views     5      8	viewModel"clr-namespace:WpfMvvmUA2.ViewModel     5        N� Title$  Liste des Membres��5       N� 
Background �#F2F2F2$	��500��66    � DataContext 5      *   $WpfMvvmUA2.ViewModel.MembreViewModel  5	   
   .��5      � .+�5   
   �� -   5        $��
Add Membre��5      $
��Left=�6&   $��
620,30,0,0q�6A   $	��Top=�6U   $��30��6m   $	��110��6y   6�   �� 5   
   $��Membres��6   $
��Left=�6"   $��	43,31,0,0q�6=   $	��Top=�6P   $��25(�6h   $
��Bold"�6v   �� 5   
    �� Orientation$ 
Horizontal=�6   $��Right=�6.   $	��Top=�6J   $��	0,60,0,10q�6b   .+�5      �� $��Filtrer par Nom��6   $��14(�6/   $��0,5,5,5q�6=   $��Center=�6N   �� 5      -   5        $��FilterTextBox��5      $��30��6+   $	��200��67   $��5,5,25,5q�6C   $	��Top=�5      $��Right=�6.   $��1q�6J   ���#E0E0E05   ,   5      �� 5   
   -   5        $��
MembreList��5      ���#cdcdcd$��25,140,25,25q�6;   $��0q�6Q   ��5      �� *FilteredMembres+ �� View 5      �� 5      .P�5       �� $�� ��6%    �� Width$ 50��6/    �� CellTemplate 5!      �� 5"      .R�5$   "   �� $��Center=�6-   $��Center=�6J   .+�5%   &   F� ����� � �� Ӏ�b �� �� ��b ��  � Ӏ� �U��b ��O � ��OӀU��O��O�U��O � Ӏ�O��b �U��  � �� � � �Z �@�� �Z  &� �^h  &�  z � &� @ŋ @��  �  �  � ��g�  � �� @ŋ ��  z ��� �^h �g� �Z  � �Z � � @(�@ŋ @(�f @`�S `,� Ӏ:T  b� ��� @(�  � @(� �`Q� @(� �� b� �I`,� ���@�p� @( � @(	���#1E88E5$��30��5&   &   $��25��61    �� Stretch$ Uniform=�6=   5'   #   5(      5*      �� 5,      $	��Nom��6%   $	 120��6W    �� DisplayMemberBinding 62   �� *Nom+6W   �� 5.      $��Prenom��6%   $	 120��6]    65   �� *Prenom+6]   �� 50      $
��Role��6%   $	 130��6Y    63   �� *Role+6Y   �� 52      $��Email��6%   $	 200��6[    64   �� *Email+6[   �� 54      $��Actions��6%   $
 auto��66    55      �� 56      .R�57   "   �� -   5           ActionButtonStyle#��[  57   )   ���#bd0921.��59   &   F�   
DeleteIcon#��[ 6+   $��12��6N   $��12��6Z   $��2q�6e   
�������$ Uniform=�5:      $��Center=�6   5;   #   5=      5?      5@      5B      5C      5D      