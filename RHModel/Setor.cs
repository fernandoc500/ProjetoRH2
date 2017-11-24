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
    [Table("Setor")]
    public class Setor : INotifyPropertyChanged
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; this.NotifyPropertyChanged("Nome"); }
        }
        private string _Nome;

        [Required]
        public DateTime DataCriacao
        {
            get { return _DataCriacao; }
            set { _DataCriacao = value; this.NotifyPropertyChanged("DataCriacao"); }
        }
        private DateTime _DataCriacao;

        public DateTime? DataExtincao
        {
            get { return _DataExtincao; }
            set { _DataExtincao = value; this.NotifyPropertyChanged("DataExtincao"); }
        }
        private DateTime? _DataExtincao;

        [ForeignKey("SetorPaiId")]
        public Setor SetorPai
        {
            get { return _SetorPai; }
            set { _SetorPai = value; this.NotifyPropertyChanged("SetorPai"); }
        }
        private Setor _SetorPai;
        public int SetorPaiId { get; set; }

        [ForeignKey("ResponsavelId")]
        public Empregado Responsavel
        {
            get { return _Responsavel; }
            set { _Responsavel = value; this.NotifyPropertyChanged("Responsavel"); }
        }
        private Empregado _Responsavel;
        public int ResponsavelId { get; set; }

        [Required]
        public string Atividades
        {
            get { return _Atividades; }
            set { _Atividades = value; this.NotifyPropertyChanged("Atividades"); }
        }
        private string _Atividades;

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
