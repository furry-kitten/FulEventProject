   M S B A M L   `   `   `  ����F  BSampoClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:SampoClient.Views.WindowsSampoClient.Views.Windows  5   	   ?$clr-namespace:SampoClient.ViewModelsSampoClient.ViewModels  5   	   6    0SampoClient.Views.Windows.AuthanenticationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Z VDevExpress.Mvvm.UI, Version=19.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:SampoClient.Views.Windows     5   	   3vm$clr-namespace:SampoClient.ViewModels     5   	     � AllowsTransparency  .  � WindowStyle$
 None=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ AuthanenticationWindow��5   	   $	��250��6(   $	��300��65    � DataContext 5      4  .SampoClient.ViewModels.AuthenticationViewModel  5   
   .��5   
   � ���#222222 � ColumnDefinitions 5      �� 5      $
��0.5* �6#   $��30��60   �� 5      $��5* �6#   �� 5      $
��0.5* �6#   $��30��60    � RowDefinitions 5      �� 5      $
��0.5* �6    $��30��6.   �� 5      $��5* �6    �� 5      $
��0.5* �6    $��30��6.   .+�5       ]� ��. $��0��6.   $��3��6>   .+�5#      ��  �� Orientation$ 
Horizontal=�6   $��Right=�5$      .+�5.      �� -   5         ��Name$ CloseApp��5.         CloseApp#��[  5/      ��50      �� *
CloseApp+.��51      �� $��/img/closeapp.png��6    $��20��6;   $	��Top=�6G   52      53      �� 56      -   5        $
��Left=�56      $��
САМПО��57      $��14(�58      $
��Bold"�6&   
���   �$	��Top=�59       
 Header#��[ 5;      �� 5=      -   5        $	��Top=�5=      #��[ 5?      5@      �� 5Q      $��1��6   $��1��5R      $ Vertical=�5S      $��Center=�5T      .+�5V      �� $��
Логин��6   $
��Left=�6)     BaseTextBlock#��[ 6D   �� 5X      -   5        	 ��Name$	 Login��5X        BaseTextBox#��[ 5Z      ��5Y      �� *LoginOrIDsha+5Z      �� 5[      $��Пароль��6   $
��Left=�6*   #��[ 6E   G� 5]      -   5        
 G�Name$
 Password��5]      �� 5`      -   5         ��Name$ Remember��5`      $!��Запомнить меня��5a        BaseCheckBox#��[ 5b      ]� 5d      $��0q�6   ��. .+�5e      �� -   5        $ Registration��5e      $
��Left=�5f        AuthorizationBtn#��[ 5g      .��5h      ]� ��. .+�5i      �� $��5��6'   $
��Left=�61   $y�Hidden=�6G   �� 5j      $��5��6'   $��Right=�61   $y�Hidden=�6H   �� 5k      $*��$Зарегистрироваться��6$   5l      5m      �� 5o      -   5        $ Authorization��5o      $��Right=�5p      #��[ 5s      ��5q      �� *SignIn+��5r      ��  �� ElementName$ Password��.��5t      ]� ��. .+�5u      �� $��5��6'   $
��Left=�61   $y�Hidden=�6G   �� 5v      $��5��6'   $��Right=�61   $y�Hidden=�6H   �� 5w      $��
Войти��6$   5x      5y      �� 5{       J� Opacity$ 0Q�6#    �� ResizeBehavior$ BasedOnAlignment=�5|   #   $��Stretch=�5}   #   $��Stretch=�5~   #   5      5�      5�      5�      