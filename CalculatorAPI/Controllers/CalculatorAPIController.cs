using CalculatorLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CalculatorAPIController : ControllerBase
    {
            private readonly CalculatorLib _calculatorLib;
            public CalculatorAPIController(CalculatorLib library)
            {
                _calculatorLib = library;

            }

            [HttpGet]
            public decimal Add(decimal num1, decimal num2)
            {
                return _calculatorLib.Add(num1, num2);  

            }

            [HttpGet]
            public decimal Subtract(decimal num1, decimal num2)
            {
               return _calculatorLib.Subtract(num1, num2);
            }
            [HttpGet]
            public decimal Multi(decimal num1, decimal num2)
            {
                return _calculatorLib.Multi(num1, num2);
        }
            [HttpGet]
            public decimal Divide(decimal num1, decimal num2)
            {
            return _calculatorLib.Divide(num1, num2);

        }

    }
}
