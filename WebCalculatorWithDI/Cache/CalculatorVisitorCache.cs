using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using WebCalculatorWithDI.Cache;
using WebCalculatorWithDI.DataBase;

namespace WebCalculatorWithDI.CalcExpressionTreeBuilder
{
    public class CalculatorVisitorCache : CalculatorVisitor
    {
        private ExpressionDbCache _cache;

        public CalculatorVisitorCache(ExpressionDbCache cache) =>
            _cache = cache;

        protected override Expression VisitBinary(BinaryExpression node)
        {
            var left = Task.Run(() => Visit(node.Left));
            var right = Task.Run(() => Visit(node.Right));

            var delay = Task.Delay(1000);
            Task.WhenAll(left, right);

            var leftResult = (decimal) ((ConstantExpression) left.Result)?.Value!;
            var rightResult = (decimal) ((ConstantExpression) right.Result)?.Value!;

            var operation = node.NodeType switch
            {
                ExpressionType.Add => "+",
                ExpressionType.Subtract => "-",
                ExpressionType.Multiply => "*",
                ExpressionType.Divide => "/"
            };

            var expressionEntity = new ExpressionEntity()
            {
                V1 = leftResult,
                V2 = rightResult,
                Op = operation
            };

            return Expression.Constant(_cache.GetOrSet(expressionEntity, () =>
            {
                var result = (decimal) CalculatorF.Program.GetResult(new string[]
                    {
                        expressionEntity.V1.ToString(),
                        expressionEntity.Op,
                        expressionEntity.V2.ToString()
                    })
                    .Value;
                delay.Wait();
                return result;
            }).Res);
        }
    }
}