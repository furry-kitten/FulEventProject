   M S B A M L   `   `   `  ����F  BSampoClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:SampoClient.Views.WindowsSampoClient.Views.Windows  5   	   ?$clr-namespace:SampoClient.ViewModelsSampoClient.ViewModels  5   	   *    $SampoClient.Views.Windows.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Z VDevExpress.Mvvm.UI, Version=19.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:SampoClient.Views.Windows     5   	   3vm$clr-namespace:SampoClient.ViewModels     5   	     � WindowStyle$
  None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � Title$ 
MainWindow��5   	   $	��450��6   $	��800��6)    � DataContext 5      0   *SampoClient.ViewModels.MainWindowViewModel  5   
   .��5      � ���#222222 � ColumnDefinitions 5   
   �� 5      $	��500��6   $
��auto �6.   �� 5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   ]� ��. $��0��6*   $��2��6:   .+�5!      ��  �� Orientation$ 
Horizontal=�6   $��Right=�5"      $��90��5#      .+�5%      ��    WindowStyle#��[  6   .��5&      �� $��/img/Collapse.png��6   5'      �� 5)      #��[  6   .��5*      �� $��/img/expand.png��6   5+      �� 5-      -   5         ��Name$ CloseApp��5-        CloseApp#��[ 5.      ��5/      �� *
CloseApp+.��50      �� $��/img/closeapp.png��6   $��20��67   $	��Top=�6C   51      52      �� 55      -   5        $
��Left=�55      $��
САМПО��56      $��14(�57      $
��Bold"�6&   
���   �$	��Top=�58       
 Header#��[ 5:      �� 5<      -   5        $	��Top=�5<      #��[ 5>      5?      �� 5A   
   -   5         ��Name$
 Menu��5B      $ Vertical=�5A      $��1��5C      $��0��6"   .+�5E      �� -   5        $ MainPage��5E      $��Главная��5F        MenuBtn#��[ 5G      �� 5I      -   5        $ Settings��5I      $��Настройки��5J      $y�Visible=�5K      #��[ 5L      5M       � 5O   
   $��1��6   $��1��6    	  � NavigationUIVisibility$	 Hidden=�5P      ��5Q      �� *CurrentPage+5R      5S      