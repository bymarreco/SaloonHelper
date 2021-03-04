namespace SaloonHelper.ViewModel
{
    public class ServicePriceCalculationViewModel
    {
        public double ServicePrice { get; set; }
        public double Rateio { get; set; }
        public double TaxaCartao { get; set; }
        public double DescontoToalha { get; set; }
        public double DescontoProdutos { get; set; }
        public double ResultadoSalao { get; set; }
        public double ResultadoProfissional { get; set; }
        public double TotalTaxas { get; set; }
        public bool DescontarTaxaAntes { get; set; }
        public double NewServicePrice { get; set; }
    }
}