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
    }
}
