namespace Calculator.Operators
{
    internal class DivideOperator : IOperator
    {
        public float run(float a, float b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a/b;
        }

        public override string ToString()
        {
            return "/";
        }
    }
}
