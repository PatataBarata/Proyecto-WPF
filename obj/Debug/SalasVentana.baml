   M S B A M L   `   `   `  ����G  CProyecto WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Proyecto_WPFProyecto_WPF  5   	       Proyecto_WPF.SalasVentana   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Proyecto_WPF     5   	     � Title$  Gestion de Salas��5   	   $	��450��6"   $	��800��6/   .��5	      ]� .+�5
   
   �� -   5         ��Name$ CambiarSalasStackPanel��5
      $��Right=�65   $	��200��6L   $	��350��6Y   $y�	Collapsed=�6e   .+�5   
   �� Sala numero:6"   �� 5   
   -   5         ��Name$ NumeroSalaTexBox��5      ��6,   ��  �� Path$ 
NumeroSala�6P   �� 5   
   Numero de butacas:6(   �� 5      -   5        $ asientosSalaTexBox��5      ��62   �� $ TotalButacas�6W   �� 5      -   5         ��Name$ aleatorioButtonSalas��5      .��5      �� -   5         ��Name$# aleatorioButtonSalasTextBlock��5      6E   5      �� 5      -   5        $ CancelarButton��5      .��6J   
Cancelar6T   5      �� 5   
   $	��Top=�6    �� Orientation$ 
Horizontal=�6*   $��Center=�6C   .+�5      �� -   5        $ añadirNuevaSalaButton��5      .��6Y   Añadir nueva sala6l   �� 5      -   5        $ modificarSalaButton��5      .��6U   Modificar sala6e   5      &   System.Windows.Controls.DataGrid  5   
   -	   5          Name$ gestionSalasLixtBox��5         AutoGenerateColumns .  	   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 * 6d   ��60   �� 
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre de la Sala��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   �� $ 
NumeroSala�6K     5      $ Numero de butacas��6%    5   %   �� $ TotalButacas�6M   5!      5"      5#      