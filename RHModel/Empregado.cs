using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHModel
{
    [Table("Empregado")]
    public class Empregado : INotifyPropertyChanged
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome {
            get { return _Nome; }
            set { _Nome = value; this.NotifyPropertyChanged("Nome"); }
        }
        private string _Nome;


        [Required]
        public string Cpf {
            get { return _Cpf; }
            set { _Cpf = value; this.NotifyPropertyChanged("Cpf"); }
        }
        private string _Cpf;

        [Required]
        public DateTime DataNascimento {
            get { return _DataNascimento; }
            set { _DataNascimento = value; this.NotifyPropertyChanged("DataNascimento"); }
        }
        private DateTime _DataNascimento;

        [Required]
        public DateTime DataContratacao {
            get { return _DataContratacao; }
            set { _DataContratacao = value; this.NotifyPropertyChanged("DataContratacao"); }
        }
        private DateTime _DataContratacao;

        [Required]
        public decimal Salario {
            get { return _Salario; }
            set { _Salario = value; this.NotifyPropertyChanged("Salario"); }
        }
        private decimal _Salario;

        [ForeignKey("CargoId")]
        public Cargo Cargo {
            get { return _Cargo; }
            set { _Cargo = value; this.NotifyPropertyChanged("Cargo"); }
        }
        private Cargo _Cargo;
        [Required]
        public int CargoId { get; set; }

        [ForeignKey("SuperiorId")]
        public Empregado Superior {
            get { return _Superior; }
            set { _Superior = value; this.NotifyPropertyChanged("Superior"); }
        }
        private Empregado _Superior;
        public int? SuperiorId { get; set; }

        public IList<Empregado> Subordinados { get; set; }
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
    }
}
