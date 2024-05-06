namespace ghabzinow.ViewModel.UtitlityBills
{
    public class ElectricityBillInquiryDto
    {
        public string ElectricityBillID { get; set; }
        public string Token { get; set; }
    }
    public class RequestDto
    {
        public string BillID { get; set; }
        public string Token { get; set; }
    }
    public class WaterBillInquiryDto
    {
        public string WaterBillID { get; set; }
        public string Token { get; set; }
    }
  
    public class MobileInquiryDto
    {
        public string MobileNumber { get; set; }
        public string Token { get; set; }
    }
    public class FixedLineNumberInquiryDto
    {
        public string FixedLineNumber { get; set; }
        public string Token { get; set; }
    }
    public class GasBillInquiryDto
    {
        public string ParticipateCode { get; set; }
        public string GasBillID { get; set; }
        public string Token { get; set; }
    }
    public class IdentityDto
    {
        public string Token { get; set; }
    }
    public class ElectricityParametersDto
    {
        public string ElectricityBillID { get; set; }
        public string TraceNumber { get; set; }
    }
    public class FixedLineNumberParametersDto
    {
        public string FixedLineNumber { get; set; }
        public string TraceNumber { get; set; }
    }
    public class GasParametersDto
    {
        public string ParticipateCode { get; set; }
        public string GasBillID { get; set; }
    }
    public class MobileParametersDto
    {
        public string MobileNumber { get; set; }
       
    }
    public class WaterParametersDto
    {
        public string WaterBillID { get; set; }
    
    }

    public class FinalRequsetDto<T>
    {
        public IdentityDto Identity { get; set; }
        public T Parameters { get; set; }

    }

}
