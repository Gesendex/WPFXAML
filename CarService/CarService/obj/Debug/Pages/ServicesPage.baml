   M S B A M L   `   `   `  ����E  ACarService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CarService.PagesCarService.Pages  5      #    CarService.Pages.ServicesPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:CarService.Pages     5      -   5          N� Title$  Список услуг��5	      .��5      �    ColorPrimary#��[  6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $
��Left=�6.   $��1��6I   .+�5      �� -   5        $��ComboSortBy��5      .@�5      �� $*��$По возрастанию цены��6   �� 5      $$��По убыванию цены��6   5      �� 5      -   5        $��ComboDicount��5      .@�5      �� $��Все��6   �� 5      $��От 0% до 5%��6   �� 5      $��От 5% до 15%��6   �� 5      $��От 15% до 30%��6   �� 5      $��От 30% до 70%��6   �� 5      $��От 70% до 100%��6   5      �� 5!      -   5        $��
TBoxSearch��5!      6(   5"      �� 5$   
   -   5        $��lViewServices��5$       $��2��6   $��Disabled=�5%      ��5&      �� 5'      .R�5(      � $��Center=�6     � Orientation$ 
Horizontal=�6=   6X   5)      ��5+      �� 5,      .R�5-      ��   ColorAccent#��[ 6    �� CornerRadius$ 15��6H    �� Padding$ 5q�6{   ��6Z   �� *	BackColor+._�5.      �  � ColumnDefinitions 5/      �� 50   "   $	��100 �63   �� 51   "   $��* �63   .+�53      �� ��6$   �� *	MainImage+�� 54      $��1��6)   .+�55   "   ��   BlockCommon#��[ 6,   $
��auto��56   ,   ��69   �� *Title+�� 58   "   $ 
Horizontal=�6-   .+�59   &   �� #��[ 60   $��Strikethrough{�5:   0   $
��auto��6P   $
��Left=�5<   0   ��5;   0   �� *Cost+ �� StringFormat$ N2��y�5=   0   �� *HasDiscountVisibility+�� 5>   &   #��[ 60   $
��auto��5?   0   $
��Left=�5@   0   ��5?   =   �� *TotalCostText+5@   0   5A   #   �� 5E   "   #��[ 6,   $
��auto��5F   ,   $
��Left=�5G   ,   $��12(�6G   ��5F   9   �� *DiscountText+5G   G   �� 5I   "   $ 
Horizontal=�6-   .+�5J   &   �� $��BtnEdit��6E   -   5        $ ��Редактировать��5J   -   y�5K   C   �� *AdminControlsVisibility+�� 5L   &   $��	BtnDelete��6?   -   5        $��Удалить��5L   -   y�5M   E   �� *AdminControlsVisibility+5N   #   5O      5P      5Q      5R      5T      �� 5V   
   -   5        $��BtnCreateService��5W   *   $��3��5V      $��Right=�6   $!��Создать услугу��5W      $	��176��5X   0   5Y      5Z      