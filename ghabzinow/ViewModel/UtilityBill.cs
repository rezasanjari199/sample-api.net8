namespace ghabzinow.ViewModel
{
    using System;
    using System.Collections.Generic;

    public class UtilityBill
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public long Amount { get; set; }
        public string BillID { get; set; }
        public string PaymentID { get; set; }
        public string PreviousDate { get; set; }
        public string CurrentDate { get; set; }
        public string PaymentDate { get; set; }
        public string BillPdfUrl { get; set; }
        public string ExtraInfo { get; set; }

        public string TariffType { get; set; }
        public string CustomerType { get; set; }
        public string SaleYear { get; set; }
        public string Cycle { get; set; }
        public string AverageConsumption { get; set; }
        public string InsuranceAmount { get; set; }
        public string TaxAmount { get; set; }
        public string PaytollAmount { get; set; }
        public string PowerPaytollAmount { get; set; }
        public string TotalDays { get; set; }

    
    }

    public class FinalyResponse<T>
    {
        public T Parameters { get; set; }
        public Status Status { get; set; }

    }
    public class Status
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }



    public class GasBill
    {
        public string Abonman { get; set; }
        public string Address { get; set; }
        public int Amount { get; set; }
        public string BillID { get; set; }
        public string BillPdfUrl { get; set; }
        public string ConsumptionType { get; set; }
        public string CurrentCounterDigit { get; set; }
        public string CurrentDate { get; set; }
        public string ExtraInfo { get; set; }
        public string FullName { get; set; }
        public string Insurance { get; set; }
        public string PaymentDate { get; set; }
        public string PaymentID { get; set; }
        public string PreviousCounterDigit { get; set; }
        public string PreviousDate { get; set; }
        public string Tax { get; set; }
    }


    public class WaterBill
    {
        public string Address { get; set; }
        public double Amount { get; set; }
        public string BillID { get; set; }
        public string BillPdfUrl { get; set; }
        public DateTime CurrentDate { get; set; }
        public string ExtraInfo { get; set; }
        public string FullName { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string PaymentID { get; set; }
        public DateTime PreviousDate { get; set; }
    }


    public class MobileBill
    {
        public MobileTermBillOutputParams MidTerm { get; set; }
        public MobileTermBillOutputParams FinalTerm { get; set; }
    }
    public class FixedLineBill
    {
        public MobileTermBillOutputParams MidTerm { get; set; }
        public MobileTermBillOutputParams FinalTerm { get; set; }
    }
    public class MobileTermBillOutputParams
    {
        public int Amount { get; set; }
        public string BillID { get; set; }
        public string PaymentID { get; set; }
        public string Cycle { get; set; }
    }

}
