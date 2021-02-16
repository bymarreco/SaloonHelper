using System.ComponentModel.DataAnnotations;

namespace SaloonHelper.ViewModel
{
    public class PriceCalculationViewModel
    {
        [Display(Name = "Preço de Custo")]
        public double InitialPrice { get; set; }
        [Display(Name = "Preço de Custo com Aumento")]
        public double NewInitialPrice { get; set; }
        [Display(Name = "Aumento")]
        public double Increase { get; set; }
        [Display(Name = "10%")]
        public double DezPorCento { get; set; }
        [Display(Name = "20%")]
        public double VintePorCento { get; set; }
        [Display(Name = "30%")]
        public double TrintaPorCento { get; set; }
        [Display(Name = "40%")]
        public double QuarentaPorCento { get; set; }
        [Display(Name = "50%")]
        public double CinquentaPorCento { get; set; }
        [Display(Name = "60%")]
        public double SessentaPorCento { get; set; }
        [Display(Name = "70%")]
        public double SetentaPorCento { get; set; }
        [Display(Name = "80%")]
        public double OitentaPorCento { get; set; }
        [Display(Name = "90%")]
        public double NoventaPorCento { get; set; }
        [Display(Name = "100%")]
        public double CemPorCento { get; set; }
        public double? NewDezPorCento { get; set; }
        public double? NewVintePorCento { get; set; }
        public double? NewTrintaPorCento { get; set; }
        public double? NewQuarentaPorCento { get; set; }
        public double? NewCinquentaPorCento { get; set; }
        public double? NewSessentaPorCento { get; set; }
        public double? NewSetentaPorCento { get; set; }
        public double? NewOitentaPorCento { get; set; }
        public double? NewNoventaPorCento { get; set; }
        public double? NewCemPorCento { get; set; }

    }
}