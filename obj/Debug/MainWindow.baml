   M S B A M L   `   `   `  ����G  CProyecto WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Proyecto_WPFProyecto_WPF  5   	       Proyecto_WPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Proyecto_WPF     5   	     � Title$  Cines 'El Pepe'��5   	   $	��450��6!   $	��800��6.    � Icon$ Imagen/Cabecera.png��5	   	    � 	Resources 5
         PlantillaPeliculasLixbox �� Orientation �� Path��%�  &	        �� 5   
   .R�5      �� 
���**��$��3q�5      ._�5      �� $ 
Horizontal=�6   $	��300��5      $	��150��6)   .+�5      �� $��5q�6   $��90��5      $��Center=�5      ��5      �� $ Cartel�5   ;   �� 5      $
��10,1q�6!   .+�5      �� 
Pelicula6.   �� 5      $	��Top=�6$   $��10q�5   $   ��5   $   �� $ Titulo�5   2   �� 5      $ 
Horizontal=�6%   .+�5      �� 	Duracion:63   �� 5      ��6(   �� *
Duracion+6D   5      �� 5      $ 
Horizontal=�6%   .+�5      �� 	Genero:61   �� 5      ��6(   �� *Genero+6B   5       �� 5!      $ 
Horizontal=�6%   .+�5"      �� Calificacion:67   �� 5#      ��6(   �� *Calificacion+6H   5$      �� 5%      $ 
Horizontal=�6%   .+�5&      �� Año:6.   �� 5'      ��6(   �� *Año+6?   5(      5)      5*      5+      5,      5-      .��5.      ]� .+�5/      �� $��Bottom=�6   .@�50      �� $��
Cines Pepe��6    64   51      o� 52   
   $	��Top=�6   .@�53      m�  m� Icon$ ds��54   2   $��_Ayuda��55   ;   57      58      �� 59      .@�5:   
   �� $��Gestor��6   .��5;      ]� .+�5<      �� .+�5=      �� -   5         ��Name$ SalasButton��5=   &   $��10q�6   .��6U   Gestionar Salas6f   �� 5>      -   5        $ SesionesButton��5>   &   $��10q�6   .��6[   Gertionar Sesiones6o   5?      �� 5@      -   5         ��Name$ cartelaCineLisBox��5@      #��[  5B      $��Disabled=�6S   ��5A      �� ��5C      �� 5D      .R�5E      � 6*   5F      5H      5I      5J      �� 5K   
   $��Venta en taquilla��6   .��5L      ]� .+�5M      �� -   5         ��Name$  CabeceraPeliculasTextBlock��5M   N   $	��Top=�6   $��Center=�61   '%Peliculas disponibles en nuestro Cine6�   �� 5N      $��Right=�6   .+�5O      �� -   5        $$ nombrePeliculaEleccionTexblock��5O       ��6H   �� $ pelicula�
pelicula6q   �� 5P      Elige sesion:60   �� 5Q      .@�5R      �� -   5        	 ��Name$	 sesionComboBox��5R   '   6A   5S      �� 5T      numero de butaca62   �� 5U      .@�5V      �� -   5        $	 numeroButacaComboBox��5V   '   6G   5W      �� 5X      -   5        $ accederAPagoButton��5X      .��69   	Aceptar6B   5Y      �� 5Z      $	��Top=�6   $��Center=�62   .+�5[      �� -	   5        $ ventaEntradaButton��5[      .��66   Venta de entradas6I   �� 5\      -
   5        $ consultaOcupacionButton��5\      .��6;   Consulta ocupacón de salas6W   5]      �� 5^      -   5        $ cartelaCissneLisBox��5^      ��67   �� ��5_      �� 5`      .R�5a      �� 
���**��$��3q�69   ._�5b      �� $ 
Horizontal=�6!   $	��300��6:   .+�5c      �� $��5q�6    $��90��6J   $��Center=�6U   ��6+   �� $ Cartel�6t   �� 5d   "   $
��10,1q�6-   .+�5e   &   �� 
Pelicula6:   �� 5f   "   $	��Top=�6,   $��10q�6^   ��6A   �� $ Titulo�6l   �� 5g   &   $ 
Horizontal=�61   .+�5h   &   �� 	Duracion:6<   �� 5i   &   ��60   �� *
Duracion+6L   5j   '   �� 5k   &   $ 
Horizontal=�61   .+�5l   &   �� 	Genero:6:   �� 5m   &   ��60   �� *Genero+6J   5n   '   �� 5o   &   $ 
Horizontal=�61   .+�5p   .   �� Calificacion:6H   �� 5q   &   ��60   �� *Calificacion+6P   5r   '   �� 5s   &   $ 
Horizontal=�61   .+�5t   2   �� Año:6B   �� 5u   &   ��60   �� *Anyo+6H   5v   '   5w   #   5x      5y      5z      5|      5~      5�      5�      5�      5�      