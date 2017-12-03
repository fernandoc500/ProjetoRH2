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
using RHView.Listagens;

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
        private IList<Empregado> _Empregados { get; set; }
        public IList<Empregado> Empregados
        {
            get { return _Empregados; }
            set { _Empregados = value; this.NotifyPropertyChanged("Empregados"); }
        }

        private Empregado _EmpregadoSelecionado;
        public Empregado EmpregadoSelecionado {
            get {return _EmpregadoSelecionado; }
            set { _EmpregadoSelecionado = value; this.NotifyPropertyChanged("EmpregadoSelecionado"); }
        }

        public CargoControl cc = new CargoControl();

        private IList<Cargo> _Cargos { get; set; }
        public IList<Cargo> Cargos
        {
            get { return _Cargos; }
            set { _Cargos = value; this.NotifyPropertyChanged("Cargos"); }
        }

        //Utilizei isso para evitar que essa janela, se aberta da listagem de cargos, não chame a MainMenu quando fechada
        Boolean omitOnClose = false;

        public ListagemEmpregado()
        {
            InicializacaoPadrao();
        }

        public ListagemEmpregado(Empregado emp, Boolean omitOnClose)
        {
            InicializacaoPadrao();
            EmpregadoSelecionado = emp;
            this.omitOnClose = omitOnClose;
        }

        private void InicializacaoPadrao()
        {
            InitializeComponent();
            this.DataContext = this;

            Empregados = new List<Empregado>();

            EmpregadoControl ec = new EmpregadoControl();
            CargoControl cc = new CargoControl();

            Empregados = ec.ObterEmpregados();
            Cargos = cc.ObterCargos();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Empregado emp = EmpregadoSelecionado;
                EmpregadoControl ec = new EmpregadoControl();
                emp.Cargo = (Cargo)ComboBoxCargo.SelectedItem;
                
                MessageBox.Show(ec.SalvarEmpregado(emp));

                Empregados = ec.ObterEmpregados();
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
            EmpregadoControl ec = new EmpregadoControl();
            EmpregadoSelecionado = new Empregado();
            EmpregadoSelecionado.DataContratacao = new DateTime(1972, 1, 1);
            EmpregadoSelecionado.DataNascimento = new DateTime(1972, 1, 1);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            if (!omitOnClose)
            {
                MainMenu mm = new MainMenu();
                mm.Show();
            }
        }

        private void btnHistoricoCargo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (EmpregadoSelecionado.Id > 0)
                {
                    ListagemHistoricoCargo lhc = new ListagemHistoricoCargo(EmpregadoSelecionado);
                    lhc.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Certifique-se de que está clicando em um registro válido");
            }
        }
    }
}
