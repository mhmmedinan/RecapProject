using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardsController : ControllerBase
    {
        private ICreditCardService _creditCardService;
        private ICustomerService _customerService;

        public CreditCardsController(ICreditCardService creditCardService, ICustomerService customerService)
        {
            _creditCardService = creditCardService;
            _customerService = customerService;
        }

        [HttpPost("add")]
        public IActionResult Add(CreditCard card)
        {
            var result = _creditCardService.Add(card);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        
          
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int userId)
        {
            var result = _creditCardService.GetByUserId(userId);
            return Ok(result.Data);
        }

        [HttpGet("getallbyid")]
        public IActionResult GetAllById(int customerId)
        {
          
            var result = _creditCardService.GetAll(customerId);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
