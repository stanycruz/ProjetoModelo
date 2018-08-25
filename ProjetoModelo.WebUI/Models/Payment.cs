using System;

namespace ProjetoModelo.WebUI.Models
{
    public class Payment
    {
        public long RegistrationId { get; set; }
        public decimal Value { get; set; }
        public DateTime Payday { get; set; }
        public string FormPayment { get; set; }
        public decimal PaymentAmount { get; set; }
        public string Historic { get; set; }
        public string Period { get; set; }
    }
}
