   M S B A M L   `   `   `  ����A  =RHView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:RHView.FormulariosRHView.Formularios  5   	   (    "RHView.Formularios.FormularioCargo   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:RHView.Formularios     5   	     � Title$  FormularioCargo��5   	   $	��140��6!   $	��300��6.   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       � ColumnDefinitions 5   
   �� 5      $
��0.8* �6   �� 5      .+�5   
   �� $��Cargo��6   $��0��6    �� 5   
   $��Salário Base��6   $��1��6'   �� 5   
   $��Superior��6   $��2��6#   �� 5   
   $��0��6   $��1��6   ��6/   ��  �� Path$ NovoCargo.Nome��� 5   
   $��1��6   $��1��6   ��6/   �� $ NovoCargo.SalarioBase��� 5   
   -   5        $��ComboBoxPai��5   o   $��2��6   $��1��6     �� DisplayMemberPath$
 Nome��6V   ��60   �� $ Cargos�6o   �� 5   
   -   5        $��	btnSalvar��5      $��Salvar��6"   $��3��63   $��0��6@   6P   �� 5   
   -   5        $��btnCancelar��5      $��Cancelar��6$   $��3��67   $��1��6D   5      5       