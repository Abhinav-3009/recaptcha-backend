using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Recaptcha.Options;
using reCAPTCHA_Backend.Helpers;
using reCAPTCHA_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reCAPTCHA_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecaptchaController : ControllerBase
    {
        private readonly RecaptchaOption _option;
        private readonly RecaptchaHelper _helper;

        public RecaptchaController(IOptions<RecaptchaOption> option)
        {
            _option = option.Value;
            _helper = new RecaptchaHelper(option);
        }


        [HttpPost]
        [Route("login")]
        public IActionResult postLogin(CaptchaViewModel model)
        {
            string captchaResponse = model.CaptchaToken;
            var validate = _helper.ValidateCaptcha(captchaResponse);
            if (!validate.Success)
            {
                return BadRequest("error error shame shame");
            }
            return Ok(new { msg="Successfull"});
        }
        [HttpGet]
        [Route("names")]
        public IActionResult getName()
        {
            return Ok(new { name = "Abhinav" });
        }
    }
}
