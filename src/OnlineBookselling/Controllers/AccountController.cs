using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineBookselling.ViewModels;
using OnlineBookselling.Services;

namespace OnlineBookselling.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromForm]LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                //var userDto = _mapper.Map<UserDto>(model);

                //var authenticationDto = await _adminService.Authenticate(userDto);
                //HttpContext.Session.SetString(model.Username, authenticationDto.Token);
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register([FromForm]RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // map dto to entity
                //var userDto = _mapper.Map<UserDto>(model);

                // save
                //_adminService.Register(userDto);
                return RedirectToAction("Login");
            }

            return View(model);
        }
    }
}