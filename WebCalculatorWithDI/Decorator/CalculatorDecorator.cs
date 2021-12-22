/*using System.Linq.Expressions;
using WebCalculatorWithDI.Cache;
using WebCalculatorWithDI.CalcExpressionTreeBuilder;
using WebCalculatorWithDI.DataBase;

namespace WebCalculatorWithDI.Decorator
{
    public class CalculatorDecorator
    {
        public enum CalculatorType
        {
            Classic = 0,
            CacheExtended = 1
        }

        public ExpressionVisitor visitor;

        public CalculatorDecorator(CalculatorType type)
        {
            switch (type)
            {
                case CalculatorType.Classic:
                    visitor = new CalculatorVisitor();
                    break;  
                    case CalculatorType.CacheExtended:
                    visitor = new CalculatorVisitorCache(new ExpressionDbCache(new ExpressionEntitysContext()));
                    break;
            }
        }
    }
}
*/