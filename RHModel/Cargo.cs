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
    [Table("Cargo")]
    public class Cargo : INotifyPropertyChanged
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal SalarioBase
        {
            get { return _SalarioBase; }
            set { _SalarioBase = value; this.NotifyPropertyChanged("SalarioBase"); }
        }
        private decimal _SalarioBase;

        [Required]
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; this.NotifyPropertyChanged("Nome"); }
        }
        private string _Nome;

        [ForeignKey("CargoPaiId")]
        public Cargo CargoPai
        {
            get { return _CargoPai; }
            set { _CargoPai = value; this.NotifyPropertyChanged("CargoPai"); }
        }
        private Cargo _CargoPai;
        public int CargoPaiId { get; set; }

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
