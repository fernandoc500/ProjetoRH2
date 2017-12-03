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
using System.Windows.Shapes;
using RHModel;
using RHControl;

namespace RHView.Formularios
{
    /// <summary>
    /// Interaction logic for FormularioCargo.xaml
    /// </summary>
    public partial class FormularioCargo : Window
    {
        public Cargo NovoCargo { get; set; }
        public IList<Cargo> Cargos { get; set; }
        CargoControl cc = new CargoControl();

        public FormularioCargo()
        {
            InitializeComponent();
            this.DataContext = this;
            NovoCargo = new Cargo();
            Cargos = cc.ObterCargos();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            NovoCargo.CargoPai = (Cargo)ComboBoxPai.SelectedValue;
            cc.SalvarCargo(NovoCargo);
            this.Close();
        }
    }
}
