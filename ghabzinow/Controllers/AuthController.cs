using AutoMapper;
using ghabzinow.DAL;
using ghabzinow.Helpers;
using ghabzinow.Models;
using ghabzinow.Services;
using ghabzinow.UoW;
using ghabzinow.ViewModel.user;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace ghabzinow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;


        public AuthController( ITokenService tokenService,IMapper mapper, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _tokenService = tokenService;
            _mapper = mapper;
            

        }
        [HttpPost("login")]
        public async Task<ActionResult> Login(LoginDto login)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var user = await _unitOfWork.UserRepository.Find(x => x.Phone.Equals(login.Phone)).FirstOrDefaultAsync();
            if (user == null)
            {
                return BadRequest("کاربری پیدا نشد");
            }
            var checkPassword = SecurePasswordHasher.Verify(login.Password, user.Password);
            if (!checkPassword)
            {
                return BadRequest("پسورد نادرست است");

            }
            var token = _tokenService.GenerateAccessToken(user,login.Day);


            //set the Grid model.

            var result = new
            {
                token,
                user = user.Id
            };
            return Ok(result);
        }

        [HttpPost("rigister")]
        public async Task<IActionResult> rigister(RigisterDto rigister)
        {
            if (!ModelState.IsValid)
            {
                return Ok(rigister);
            }
            var user = await _unitOfWork.UserRepository.Find(x => x.Phone.Equals(rigister.Phone)).FirstOrDefaultAsync();
            if (user != null)
            { 
                return BadRequest(new { message = "کاربر از قبل ثبت نام کرده است لطقا از صفحه ی ورود استفاده کنید." });
            }
            string hashpassword = SecurePasswordHasher.Hash(rigister.Password);
            rigister.Password = hashpassword;
            var person = _mapper.Map<User>(rigister);
           await _unitOfWork.UserRepository.AddAsync(person);
            await _unitOfWork.CompleteAsync();
            return Ok(new { message = "ثبت نام شما با موفقیت انجام شد." });
           
          
        }
    }
}
