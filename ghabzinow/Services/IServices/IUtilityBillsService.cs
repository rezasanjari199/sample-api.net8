using ghabzinow.ViewModel;
using ghabzinow.ViewModel.UtitlityBills;

namespace ghabzinow.Services.IServices
{
    public interface IUtilityBillsService
    {
        Task< FinalyResponse<UtilityBill>> ElectricityBillInquiry(ElectricityBillInquiryDto bill);
        Task<FinalyResponse<GasBill>> GasBillInquiry(GasBillInquiryDto bill);
        Task<FinalyResponse<WaterBill>> WaterBillInquiry(WaterBillInquiryDto bill);
        Task<FinalyResponse<MobileBill>> TeleKishMobile(MobileInquiryDto bill);
        Task<FinalyResponse<MobileBill>> MCIMobileBillInquiry(MobileInquiryDto bill);
        Task<FinalyResponse<FixedLineBill>> FixedLine(FixedLineNumberInquiryDto bill);
    }
}
