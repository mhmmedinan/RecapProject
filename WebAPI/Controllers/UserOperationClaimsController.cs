using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserOperationClaimsController : ControllerBase
    {
        private IUserOperationClaimsService _claimsService;

        public UserOperationClaimsController(IUserOperationClaimsService claimsService)
        {
            _claimsService = claimsService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _claimsService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(UserOperationClaim userOperationClaim)
        {

            var result = _claimsService.Add(userOperationClaim);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(UserOperationClaim userOperationClaim)
        {

            var result = _claimsService.Update(userOperationClaim);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }


        [HttpPost("delete")]
        public IActionResult Delete(UserOperationClaim userOperationClaim)
        {

            var result = _claimsService.Delete(userOperationClaim);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {

            var result = _claimsService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }

    }
}
