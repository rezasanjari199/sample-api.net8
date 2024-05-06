using ghabzinow.BLL;
using ghabzinow.UoW;
using ghabzinow.ViewModel;
using ghabzinow.ViewModel.UtitlityBills;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ghabzinow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UtilityBillsController : BaseApiController
    {
        
        public UtilityBillsController(IUnitOfWork unitOfWork,IModelFactory modelFactory) : base(unitOfWork,modelFactory)
        {
        }
        [HttpPost("ElectricityBillInquiry")]
        public async Task<IActionResult> ElectricityBillInquiry(ElectricityBillInquiryDto requestDto)
        {
            try
            {
                var verfiyToken = _modelFactory.TokenService.VerifyToken(requestDto.Token);
                if(!verfiyToken)
                {
                    return Unauthorized();
                }
                
                var user = _unitOfWork.UserRepository.Get(UserId(requestDto.Token));
                if (user ==null)
                {
                    return BadRequest("کاربر پیدا نشد");
                }
                if (user.Wallet < 5)
                {
                    return await CustomResponse(false, 400, "عدم موجودی کیف پول", user);

                }
                var bill = await _unitOfWork.UtilityBillsService.ElectricityBillInquiry(requestDto) ;

            if (bill.Parameters == null)
            {  
              return  await CustomResponse<Status>(false,400,bill.Status.Description,bill.Status,TypePublicBill.ElectricityConstanst,400);
            }
               await _modelFactory.TransactionService.WithDrawalByInquiry(user.Id, 5);
                return await CustomResponse<FinalyResponse<UtilityBill>>(true, 200, bill.Status.Description, bill, TypePublicBill.ElectricityConstanst, 400);

            }
            catch (Exception ex)
            {

                return await CustomResponse(false, 400, ex.Message, 400, TypePublicBill.ElectricityConstanst, 400);

            }

        }
        [HttpPost("GasBillInquiry")]
        public async Task<IActionResult> GasBillInquiry(GasBillInquiryDto requestDto)
        {
            try
            {
                var verfiyToken = _modelFactory.TokenService.VerifyToken(requestDto.Token);
                if (!verfiyToken)
                {
                    return Unauthorized();
                }

                var user = _unitOfWork.UserRepository.Get(UserId(requestDto.Token));
                if (user == null)
                {
                    return BadRequest("کاربر پیدا نشد");
                }
                if (user.Wallet < 5)
                {
                    return await CustomResponse(false, 400, "عدم موجودی کیف پول", user);

                }
                var bill = await _unitOfWork.UtilityBillsService.GasBillInquiry(requestDto);

                if (bill.Parameters == null)
                {
                    return await CustomResponse<Status>(false, 400, bill.Status.Description, bill.Status, TypePublicBill.GasConstanst, 400);
                }
                await _modelFactory.TransactionService.WithDrawalByInquiry(user.Id, 5);
                return await CustomResponse<FinalyResponse<GasBill>>(true, 200, bill.Status.Description, bill, TypePublicBill.GasConstanst, 400);

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost("WaterBillInquiry")]
        public async Task<IActionResult> WaterBillInquiry(WaterBillInquiryDto requestDto)
        {
            try
            {
                var verfiyToken = _modelFactory.TokenService.VerifyToken(requestDto.Token);
                if (!verfiyToken)
                {
                    return Unauthorized();
                }

                var user = _unitOfWork.UserRepository.Get(UserId(requestDto.Token));
                if (user == null)
                {
                    return BadRequest("کاربر پیدا نشد");
                }
                if (user.Wallet < 5)
                {
                    return await CustomResponse(false, 400, "عدم موجودی کیف پول", user);

                }
                var bill = await _unitOfWork.UtilityBillsService.WaterBillInquiry(requestDto);

                if (bill.Parameters == null)
                {
                    return await CustomResponse<Status>(false, 400, bill.Status.Description, bill.Status, TypePublicBill.WaterConstanst, 400);
                }
                await _modelFactory.TransactionService.WithDrawalByInquiry(user.Id, 5);
                return await CustomResponse<FinalyResponse<WaterBill>>(true, 200, bill.Status.Description, bill, TypePublicBill.WaterConstanst, 400);

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost("FixedLineBillInquiry")]
        public async Task<IActionResult> FixedLineBillInquiry(FixedLineNumberInquiryDto requestDto)
        {
            try
            {
                var verfiyToken = _modelFactory.TokenService.VerifyToken(requestDto.Token);
                if (!verfiyToken)
                {
                    return Unauthorized();
                }

                var user = _unitOfWork.UserRepository.Get(UserId(requestDto.Token));
                if (user == null)
                {
                    return BadRequest("کاربر پیدا نشد");
                }
                if (user.Wallet < 5)
                {
                    return await CustomResponse(false, 400, "عدم موجودی کیف پول", user);

                }
                var bill = await _unitOfWork.UtilityBillsService.FixedLine(requestDto);

                if (bill.Parameters == null)
                {
                    return await CustomResponse<Status>(false, 400, bill.Status.Description, bill.Status, TypePublicBill.TeleKishMobileConstanst, 400);
                }
                await _modelFactory.TransactionService.WithDrawalByInquiry(user.Id, 5);
                return await CustomResponse<FinalyResponse<FixedLineBill>>(true, 200, bill.Status.Description, bill, TypePublicBill.TeleKishMobileConstanst, 400);

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [HttpPost("MCIMobileBillInquiry")]
        public async Task<IActionResult> MCIMobileBillInquiry(MobileInquiryDto requestDto)
        {
            try
            {
                var verfiyToken = _modelFactory.TokenService.VerifyToken(requestDto.Token);
                if (!verfiyToken)
                {
                    return Unauthorized();
                }

                var user = _unitOfWork.UserRepository.Get(UserId(requestDto.Token));
                if (user == null)
                {
                    return BadRequest("کاربر پیدا نشد");
                }
                if (user.Wallet < 5)
                {
                    return await CustomResponse(false, 400, "عدم موجودی کیف پول", user);

                }
                var bill = await _unitOfWork.UtilityBillsService.MCIMobileBillInquiry(requestDto);

                if (bill.Parameters == null)
                {
                    return await CustomResponse<Status>(false, 400, bill.Status.Description, bill.Status, TypePublicBill.TeleKishMobileConstanst, 400);
                }
                await _modelFactory.TransactionService.WithDrawalByInquiry(user.Id, 5);
                return await CustomResponse<FinalyResponse<MobileBill>>(true, 200, bill.Status.Description, bill, TypePublicBill.TeleKishMobileConstanst, 400);

            }
            catch (Exception ex)
            {

                throw;
            }
        }
     
   
    }
}
