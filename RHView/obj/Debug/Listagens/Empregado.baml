   M S B A M L   `   `   `  ����A  =RHView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:RHViewRHView  5   	       RHView.ListagemEmpregado   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:RHView     5   	   -   5          � Title$  Listagem de Empregados��5   	   $	��525��6(   $	��450��65   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      �� 5      .+�5   
   o� $��0��6   $
��Left=�6   $��20��67   $��0,0,0,0q�6C   $	��Top=�6T   .@�5      m� $��Arquivo��6   6*   m� 5      $��
Relatório��6   .@�5      m� -   5        $��RelatorioTeste��5      $��RelatorioTeste��5      5   :   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��DGEmp��5      $��1��5         AutoGenerateColumns .  ��5      ��  �� Path$ 
Empregados� �� SelectedItem 5      �� $ EmpregadoSelecionado�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Nome��6a   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Nome+   ClipboardContentBinding 6>   Z� 6a     5      $ Data de Nascimento��6k    6%   �� *DataNascimento+ 6H   Z� 6k     5       $ Idade��6b    6%   �� *Idade+ 6?   Z� 6b     5!      $ Salário��6d    6%   �� *	Salario+ 6A   Z� 6d     5"      $ Cargo��6g    6%   �� *
Cargo.Nome+ 6D   Z� 6g   5$      � 5%   
   $��2��6    5&      �� 5'      $
��Auto �6    �� 5(      $
��Auto �6    �� 5)      $
��Auto �6    �� 5*      $
��Auto �6    �� 5+      $
��Auto �6    �� 5,      $
��Auto �6    �� 5-      $
��Auto �6    �� 5.      �� 5/      �� 50      	 � ColumnDefinitions	 52      �� 53      6%   �� 54      6%   �� 55      6%   �� 56      6%   .+�58      �� $��0��6   $��0��6!   $��2��61   .��6E   Nome6K   �� 59      $��1��6   $��0��6!   $��2��61   .��6E   CPF6J   �� 5:      $��2��6   $��0��6!   $��2��61   .��6E   
Salário6N   �� 5;      $��3��6   $��0��6!   $��2��61   .��6E   Data de Nascimento6Y   �� 5<      $��4��6   $��0��6!   $��2��61   .��6E   Data de Contratação6Z   �� 5=      $��5��6   $��0��6!   $��2��61   .��6E   Cargo6L   �� 5?      $��0��6   $��2��6#   $��2��63   ��6G   �� $ EmpregadoSelecionado.Nome�6{   �� 5@      $��1��6   $��2��6#   $��2��63   ��6G   �� $ EmpregadoSelecionado.Cpf�6z   �� 5A      $��2��6   $��2��6#   $��2��63   ��6G   �� $" EmpregadoSelecionado.Salario�6~   (  "System.Windows.Controls.DatePicker  5B      $��3��6   $��2��6&   $��2��66   
   SelectedDate
 6J   �� $) #EmpregadoSelecionado.DataNascimento�6�     5C      $��4��6   $��2��6&   $��2��66   
 6J   �� $* $EmpregadoSelecionado.DataContratacao�6�   �� 5D      -   5        $��ComboBoxCargo��5J      $��5��5E      $��2��5F      $��2��5G       �� DisplayMemberPath$
 Nome��5K      ��5H      �� $ Cargos� �� SelectedValue 5I      �� $  EmpregadoSelecionado.Cargo�5K      �� 5N      -   5        $��btnHistoricoCargo��5N      $��Ver histórico de cargos��6.   $��7��6P   $��2��6]   $��2��6m   $��2��6�   6�   �� 5P      -   5        $��	btnSalvar��5P      $��Salvar��6&   $��9��67   $��0��6D   6U   �� 5Q      -   5        $��btnNovo��5Q      $
��Novo��6$   $��9��63   $��1��6@   6P   �� 5R      -   5        $��btnCancelar��5R      $��Cancelar��6(   $��9��6;   $��2��6H   6X   �� 5S      -	   5        $��
btnRemover��5S      $��Remover��6'   $��9��69   $��3��6F   $��27��6V   $	��Top=�6b   6z   5U      5V      5W      