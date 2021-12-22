using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using WebCalculatorWithDI.CalcExpressionTreeBuilder;
using WebCalculatorWithDI.Decorator;
using static WebCalculatorWithDI.Decorator.CalculatorDecorator;

namespace WebCalculatorWithDI.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet, Route("Calcs")]
        public IActionResult Calcs([FromServices] IExpressionCalculator calculator, string expressionString)
        {
            if (!calculator.TryParseStringIntoExpression(expressionString, out var exp))
            {
                return Ok("Error");
            }

            var calculatorDecorator = new CalculatorDecorator(CalculatorType.CacheExtended);

            var result = calculatorDecorator.visitor.Visit(exp);
            return Ok(result.ToString());
        }
    }
}
