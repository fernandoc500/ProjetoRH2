using Microsoft.Reporting.WinForms;
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

namespace RHView.Relatorios
{
    /// <summary>
    /// Lógica interna para RelatorioTesteTres.xaml
    /// </summary>
    public partial class RelatorioTesteTres : Window
    {
        public RelatorioTesteTres()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            teste.LocalReport.ReportEmbeddedResource = 
                "RHView.Relatorios.RelatorioTeste.rdlc";

            IList<Relatorio> dados = new List<Relatorio>();
            var dataSource = new ReportDataSource("DataSet1", dados);

            teste.LocalReport.DataSources.Add(dataSource);

            teste.RefreshReport();
        }
    }
}
