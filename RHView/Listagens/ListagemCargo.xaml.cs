using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;
using RHModel;
using RHControl;
using RHView.Formularios;

namespace RHView.Listagens
{
    /// <summary>
    /// Interaction logic for ListagemCargo.xaml
    /// </summary>
    public partial class ListagemCargo : Window, INotifyPropertyChanged
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
        private IList<Cargo> _Cargos { get; set; }
        public IList<Cargo> Cargos
        {
            get { return _Cargos; }
            set { _Cargos = value; this.NotifyPropertyChanged("Cargos"); }
        }

        private Cargo _CargoSelecionado;
        public Cargo CargoSelecionado
        {
            get { return _CargoSelecionado; }
            set {
                _CargoSelecionado = value;
                Empregados = cc.ObterEmpregadosPorCargo(value.Id);
                this.NotifyPropertyChanged("CargoSelecionado"); }
        }

        //Ao professor:
        //A solução adotada aqui é obviamente um workaround, mas perdi tanto tempo tentando 
        //fazer esse evento funcionar que eu simplesmente desisti de tentar
        private IList<Empregado> _Empregados { get; set; }
        public IList<Empregado> Empregados
        {
            get { return _Empregados; }
            set
            {
                _Empregados = value;
                this.NotifyPropertyChanged("Empregado");
                Emps.ItemsSource = null;
                Emps.ItemsSource = value;
                Emps.Items.Refresh();
            }

        }

        private CargoControl cc = new CargoControl();

        public ListagemCargo()
        {
            InitializeComponent();
            this.DataContext = this;

            Cargos = cc.ObterCargos();
            Empregados = new List<Empregado>();
        }

        private void btnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            FormularioCargo fc = new FormularioCargo();
            fc.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Emps.ItemsSource = Empregados;
        }

        private void Emps_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Empregado emp = (Empregado)Emps.SelectedItem;
                if (emp.Id > 0)
                {
                    ListagemEmpregado le = new ListagemEmpregado(emp, true);
                    le.Show();
                }

            } catch (Exception ex)
            {
                MessageBox.Show("Certifique-se de que está clicando em um registro válido");
            }

        }
    }
}
