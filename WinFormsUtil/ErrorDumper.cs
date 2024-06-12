namespace WinFormsUtil
{
    public class ErrorDumper
    {
        private readonly string _topMessage;

        public ErrorDumper(String m = "Bitte wenden Sie sich an einen Administrator.")
        {
            _topMessage = m + Environment.NewLine;
        }

        public void Dump(Exception ex)
        {
            MessageBox.Show(_topMessage + ex.ToString());
        }

        public void ArrayDump(int[,] arr)
        {
            string str = "";
            for (int c = 0; c < arr.GetLength(0); c++)
            {
                for (int r = 0; r < arr.GetLength(1); r++)
                {
                    str += arr[c, r] + " ";
                }
                str += Environment.NewLine;
            }
            MessageBox.Show(str);
        }

    }
}
