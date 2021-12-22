using System.Linq.Expressions;

namespace WebCalculatorWithDI.Decorator
{
    public interface ICalculatorVisitor
    {
        public Expression Visit();
    }
}
