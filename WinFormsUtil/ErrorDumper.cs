namespace WinFormsUtil
{
    public class ErrorDumper
    {
        private readonly string _topMessage;

        public ErrorDumper(String m)
        {
            _topMessage = m + Environment.NewLine;
        }

        public void Dump(Exception ex)
        {
            MessageBox.Show(_topMessage + ex.ToString());
        }
    }
}
