   M S B A M L   `   `   `  ����C  ?BookClub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BookClubBookClub  5   	       BookClub.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:BookClub     5   	     � Title$$  ООО Книжный Клуб��5   	   $	��720��6"   $
��1280��6/   $	��720��5	   	   $
��1280��6   .��5
      �  � RowDefinitions 5   
   �� 5      $
��1.5* �6   �� 5      $��6* �6   �� 5      $��* �6   .+�5   
   � $��0��6   
��� ��� � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� $��1��6   $$��ООО Книжный Клуб��6(   $
��16pt(�6@   $��Center=�6P   $��Center=�6k   �� 5       �� Orientation$ 
Horizontal=�6   $��2��62   $��Right=�6B   $��0,0,10,0q�6^   .+�5      �� -   5        $��BookListBtn��5   /   $��Список книг��6   $	��200��6B   $��50��6N   $
��14pt(�6Z   $��0,0,10,0q�6j   6|   �� 5      -   5        $��CartBtn��5   +   $��Корзина��6   $	��200��6:   $��50��6F   $
��14pt(�6R   6b   5      5       � 5   
   -   5        $��MainProgrammFrm��5      $��1��6     � NavigationUIVisibility$ Hidden=�64   � 5   
   
��� ���$��2��6#   .+�5      �� $ 
Horizontal=�6   $��Right=�62   $��Center=�6N   .+�5      �� -   5         ��Name$ 	GoBackBtn��5      $��
Назад��6,   $	��200��6<   $��50��6H   $
��14pt(�6T   $��0,0,10,0q�6d   6v   �� 5       -   5        $ GoForwardBtn��5       $��Вперед��6/   $	��200��6@   $��50��6L   $
��14pt(�6X   $��0,0,10,0q�6h   6z   5!      5"      5#      5$      