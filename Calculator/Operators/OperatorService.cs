using System.Text;
using System.Text.RegularExpressions;

namespace Calculator.Operators
{
    public class OperatorService
    {
        private List<IOperator> _operators;

        public OperatorService()
        {
            _operators = new List<IOperator>
            {
                new AddOperator(),
                new SubstractOperator(),
                new MultiplyOperator(),
                new DivideOperator(),
            };
        }

        public IOperator GetOperatorByLiteral(string literal)
        {
            foreach (IOperator o in _operators)
            {
                if (o.ToString() == literal)
                {
                    return o;
                }
            }
            throw new InvalidOperationException();
        }

        public List<string> GetAllLiterals()
        {
            List<string> literals = new List<string>();
            foreach (IOperator operatorInstance in _operators)
            {
                literals.Add(operatorInstance.ToString());
            }
            return literals;
        }

        public String GetRegexPattern()
        {
            StringBuilder sb = new();
            foreach (IOperator operatorInstance in _operators)
            {
                sb.Append(operatorInstance.ToString());
            }

            return (
                "^[" +
                Regex.Replace(sb.ToString(), "([\"+*])", @"\\$1") +
                "]$"
                );
        }

    }
}
