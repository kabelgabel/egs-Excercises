using System.Text;
using System.Text.RegularExpressions;
using Calculator.Operators;

namespace Calculator
{
    public class Calculator
    {
        private List<IOperator> _operators;

        public Calculator()
        {
            _operators = new List<IOperator>
            {
                new AddOperator(),
                new SubstractOperator(),
                new MultiplyOperator(),
                new DivideOperator(),
            };
        }

        private IOperator GetOperatorByLiteral(string literal)
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

        public string GetRegexPattern()
        {
            StringBuilder sb = new();
            foreach (IOperator operatorInstance in _operators)
            {
                sb.Append(operatorInstance.ToString());
            }

            return
                "^[" +
                Regex.Replace(sb.ToString(), "([\"+*])", @"\\$1") +
                "]$"
                ;
        }

        public float Calculate(float a, float b, string opString)
        {
            IOperator op = GetOperatorByLiteral(opString);
            return op.run(a, b); ;
        }

    }
}
