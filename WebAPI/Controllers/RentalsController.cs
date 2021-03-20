using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Entities.DTOs;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;
        private IPaymentService _paymentService;

        public RentalsController(IRentalService rentalService,IPaymentService paymentService)
        {
            _rentalService = rentalService;
            _paymentService = paymentService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _rentalService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getdetail")]
        public IActionResult GetRentalDetails()
        {
            Thread.Sleep(5000);
            var result = _rentalService.GetRentalDetail();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Rental rental)
        {

            var result = _rentalService.Add(rental);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }

        [HttpGet("returnupdate")]
        public IActionResult ReturnUpdate(Rental rental)
        {
            {
                var result = _rentalService.UpdateReturnDate(rental);
                if (result.Success)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }

            
        }

        [HttpPost("paymentadd")]
        public ActionResult PaymentAdd(RentalPaymentCreditDto rentalPaymentCreditDto)
        {
            var paymentResult = _paymentService.CreditPayment(rentalPaymentCreditDto.PaymentCredit);
            if (!paymentResult.Success)
            {
                return BadRequest(paymentResult);
            }
            var result = _rentalService.Add(rentalPaymentCreditDto.Rental);

            if (result.Success)
                return Ok(result);
            else
            {
                throw new System.Exception(result.Message);
                             
            }
        }

        [HttpPost("transaction")]
        public IActionResult TransactionTest(Rental rental)
        {

            var result = _rentalService.TransactionalOperation(rental);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
