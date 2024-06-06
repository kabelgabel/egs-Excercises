namespace Calculator.Operators
{
    internal class MultiplyOperator : IOperator
    {
        public float run(float a, float b)
        {
            return a*b;
        }

        public override string ToString()
        {
            return "*";
        }
    }
}
