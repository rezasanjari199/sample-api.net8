using ghabzinow.BLL;
using ghabzinow.Models;
using ghabzinow.UoW;
using ghabzinow.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ghabzinow.Controllers
{

    public class BaseApiController : Controller
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IModelFactory _modelFactory;

        protected BaseApiController(IUnitOfWork unitOfWork, IModelFactory modelFactory)
        {
            _unitOfWork = unitOfWork;
            _modelFactory = modelFactory;
        }

        protected IUnitOfWork UnitOfWork => _unitOfWork;
        protected IModelFactory ModelFactory => _modelFactory;
        //protected int UserId(string token)
        //{
        //    get
        //    {
        //        return _modelFactory.TokenService.UserId(token);
        //        //var identity = HttpContext.User.Identity as ClaimsIdentity;
        //        //var userIdCalim = identity.Claims.Where(x => x.Type == ClaimTypes.NameIdentifier).FirstOrDefault();
        //        //return userIdCalim == null ? 0 : int.Parse(userIdCalim.Value);
        //    };
            
        //}
        protected int UserId(string token)
        {
            return _modelFactory.TokenService.UserId(token);
        }


        protected async Task< IActionResult> CustomResponse<T>(bool status, int httpStatus, string message, T value,TypePublicBill type =TypePublicBill.ElectricityConstanst, int? errorCode = null)
        {   
            var log = new LogInquiry()
                {
                    IsSuccess = status,
                    Type = type,
                };
               await _unitOfWork.LogInquirtyRepository.AddAsync(log);
              await  _unitOfWork.CompleteAsync();
            if (status)
            {
                var responce = new SuccessResponce<T>() { success = true, message = message, data = value };
             
                return StatusCode(httpStatus, responce);
               
            }
            else
            {
                var responce = new ErrorResponce() { success = false, message = message, data = value, errorCode = errorCode };
                return StatusCode(httpStatus, responce);
            }
        }
        protected IActionResult CustomResponseList<T>(bool status, int httpStatus, string message, List<T> value, int? errorCode = null)
        {
            if (status)
            {
                var responce = new SuccessResponceList<T>() { success = true, message = message, data = value };
                return StatusCode(httpStatus, responce);
            }
            else
            {
                var responce = new ErrorResponce() { success = false, message = message, data = value, errorCode = errorCode };
                return StatusCode(httpStatus, responce);
            }
        }
        protected IActionResult ExceptionHandler(int Status, string Error)
        {
            ErrorDto error = new ErrorDto
            {
                ErrorMessages = new List<string>()
            };
            error.ErrorMessages.Add(Error);
            return StatusCode(Status, error);
        }
    }
}
