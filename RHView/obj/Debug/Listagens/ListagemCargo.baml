   M S B A M L   `   `   `  ����A  =RHView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:RHView.ListagensRHView.Listagens  5   	   $    RHView.Listagens.ListagemCargo   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:RHView.Listagens     5   	   -   5          � Title$  ListagemCargo��5   	   $	��300��6   $	��300��6,   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      $��30 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��GrCargos��5      $��0��5      $��2��5         AutoGenerateColumns .     
IsReadOnly . ��5      ��  �� Path$ Cargos� �� SelectedItem 5      �� $ CargoSelecionado�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Nome��6a   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� *Nome+
   ClipboardContentBinding
 6>   Z� 6a     5      $ Salário Base��6h   	 6%   �� *SalarioBase+
 6E   Z� 6h     5      $ Superior��6j   	 6%   �� *CargoPai.Nome+
 6G   Z� 6j   5         5!   
   -   5        $
��Emps��5"      $��1��5#      $��2��5$       .   . ��5%      �� $ 
Empregados� 5(        5)      $
 Nome��6a   	 6%   �� *Nome+
 6>   Z� 6a     5*      $ Data de Contratação��6n   	 6%   �� *InicioUltimoCargo+
 6K   Z� 6n   5,      �� 5-   
   -   5        $��btnAdicionar��5-      $��
Novo Cargo��6%   $��2��6:   $��0��6G   6W   �� 5.   
   -   5        $��
btnRemover��5.      $��Remover Cargo��6#   $��2��6;   $��1��6H   6X   51      52      