using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RHModel;
using System.ComponentModel;
using RHControl;

namespace RHView
{
    public partial class ListagemEmpregado : Window, INotifyPropertyChanged
    {
        #region "NotifyPropertyChanged"
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new
                PropertyChangedEventArgs(info));
            }
        }
        #endregion
        public IList<Empregado> Empregados { get; set; }
        private Empregado _EmpregadoSelecionado;
        public Empregado EmpregadoSelecionado {
            get {return _EmpregadoSelecionado; }
            set { _EmpregadoSelecionado = value; this.NotifyPropertyChanged("EmpregadoSelecionado"); }
        }

        public ListagemEmpregado()
        {

            InitializeComponent();
            this.DataContext = this;


            // popular a propriedade com um list all de empregados
            Empregados = new List<Empregado>();

            Cargo c = new Cargo();
            c.Nome = "Teste";
            c.SalarioBase = 1000;

            Empregado emp2 = new Empregado();
            emp2.Nome = "Chefe Teste";
            emp2.Cpf = "000.191.000-00";
            emp2.DataNascimento = new DateTime(2002, 5, 25);
            emp2.DataContratacao = new DateTime(2015, 4, 9);
            emp2.Salario = 5000;
            emp2.Cargo = c;

            
            Empregado emp = new Empregado();
            emp.Nome = "Subordinado Teste";
            emp.Cpf = "086.194.469-08";
            emp.Cargo = c;
            emp.DataNascimento = new DateTime(2001, 4, 20);
            emp.DataContratacao = new DateTime(2017, 4, 20);
            emp.Superior = emp2;
            emp.Salario = 1000;


            EmpregadoControl ec = new EmpregadoControl();
            CargoControl cc = new CargoControl();

            cc.SalvarCargo(c);
            ec.SalvarEmpregado(emp2);
            ec.SalvarEmpregado(emp);


            Empregados = ec.ObterEmpregados();
            
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Empregado emp = EmpregadoSelecionado;
                EmpregadoControl ec = new EmpregadoControl();
                ec.SalvarEmpregado(emp);
            } catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RelatorioTeste_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNovo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
