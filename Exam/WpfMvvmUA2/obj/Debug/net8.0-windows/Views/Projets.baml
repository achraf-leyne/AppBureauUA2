   M S B A M L   `   `   `  ����E  AWpfMvvmUA2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WpfMvvmUA2.ViewsWpfMvvmUA2.Views  5      ;"clr-namespace:WpfMvvmUA2.ViewModelWpfMvvmUA2.ViewModel  5          WpfMvvmUA2.Views.Projets   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      0localclr-namespace:WpfMvvmUA2.Views     5      8	viewModel"clr-namespace:WpfMvvmUA2.ViewModel     5        N� Title$  Projets��5      $	��500��6    � DataContext 5      +   %WpfMvvmUA2.ViewModel.ProjetsViewModel  5   
   .��5      � .+�5   
   ]� $��0��6   $��0,0,0,10q�6!   .+�5      �� $��Projets��6   $��25(�6'   $��	30,30,0,0q�65   $
��Bold"�6H   �� 5      -   5        $��30��5      $��Add Project��6!   $	��105��67   $��Center=�6C   $��5q�5      $��	0,25,25,0q�6!   $	��Top=�64   $��Right=�5      $��1q�61   ���#E0E0E05      5      �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Right=�6;   $	��Top=�6W   $��	0,60,0,10q�6o   .+�5      �� $��Filtrer par Nom��6   $��14(�6/   $��0,5,5,5q�6=   $��Center=�6N   �� 5      -   5        $��FilterTextBox��5      $��30��6+   $	��200��67   $��5,5,25,5q�6C   $	��Top=�5      $��Right=�6.   $��1q�6J   ���#E0E0E05   ,   5      �� 5   
   -   5        $��ProjectList��5       $��2��6   ���#cdcdcd$��25,140,25,25q�6I   $��0q�6_   $	��750��5   3   ��6   �� *	Projets+ �� View 5       �� 5!      .P�5"      �� $	��Nom��6%    �� Width$	 270��6W    �� DisplayMemberBinding 62   �� *Nom+6W   �� 5%      $��
Avancement��6%   $	 300��69    �� CellTemplate 5&      �� 5'      .R�5(   "   �� $ 
Horizontal=�6-   $
��Left=�6F   .+�5)   &   �  � Minimum$ 0Q�62    � Maximum$	 100Q�6>   $��20��5*   2   $	��200��6>   
��� � �
�������	 � Value	 5)   L   �� *
Avancement+5*   ]   �� 5+   &   $��Center=�5,   0   $��5,0,0,0q�6K   ��5+   0   �� *
Avancement+
 �� StringFormat$

 {0}%��5,   K   5-   #   5.      50      �� 53      $��Actions��6%   $	 250��66    54      �� 55      .R�56   "   ��    ActionButtonStyle#��[  6)   ���#bd0921��57   )   �� *" DataContext.DeleteProjectCommand+ �� RelativeSource ��  �� AncestorType Page��58   )   �� .��59   &   F�   
DeleteIcon#��[ 6+   $��12��6N   $��12��6Z   $��2q�6e   
������� �� Stretch$ Uniform=�5:   +   $��Center=�6=   5;   #   5<      5>      5?      5A      5B      5C      