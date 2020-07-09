using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RestApiAspNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // GET api/values/sum/5/5
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if(Util.IsNumeric(firstNumber) && Util.IsNumeric(secondNumber))
            {
                var sum = Util.ConvertToDecimal(firstNumber) + Util.ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        // GET api/values/subtraction/5/5
        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult Subtraction(string firstNumber, string secondNumber)
        {
            if (Util.IsNumeric(firstNumber) && Util.IsNumeric(secondNumber))
            {
                var subtraction = Util.ConvertToDecimal(firstNumber) - Util.ConvertToDecimal(secondNumber);
                return Ok(subtraction.ToString());
            }
            return BadRequest("Invalid Input");
        }

        // GET api/values/division/5/5
        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult Division(string firstNumber, string secondNumber)
        {
            if (Util.IsNumeric(firstNumber) && Util.IsNumeric(secondNumber))
            {
                var division = Util.ConvertToDecimal(firstNumber) / Util.ConvertToDecimal(secondNumber);
                return Ok(division.ToString());
            }
            return BadRequest("Invalid Input");
        }

        // GET api/values/multiplication/5/5
        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(string firstNumber, string secondNumber)
        {
            if (Util.IsNumeric(firstNumber) && Util.IsNumeric(secondNumber))
            {
                var multiplication = Util.ConvertToDecimal(firstNumber) * Util.ConvertToDecimal(secondNumber);
                return Ok(multiplication.ToString());
            }
            return BadRequest("Invalid Input");
        }

        // GET api/values/mean/5/5
        [HttpGet("mean/{firstNumber}/{secondNumber}")]
        public IActionResult Mean(string firstNumber, string secondNumber)
        {
            if (Util.IsNumeric(firstNumber) && Util.IsNumeric(secondNumber))
            {
                var mean = (Util.ConvertToDecimal(firstNumber) + Util.ConvertToDecimal(secondNumber)) / 2;
                return Ok(mean.ToString());
            }
            return BadRequest("Invalid Input");
        }

        // GET api/values/subtraction/5/5
        [HttpGet("squareroot/{number}")]
        public IActionResult SquareRoot(string number)
        {
            if (Util.IsNumeric(number))
            {
                var squareRoot = Math.Sqrt((double) Util.ConvertToDecimal(number));
                return Ok(squareRoot.ToString());
            }
            return BadRequest("Invalid Input");
        }
    }
}
