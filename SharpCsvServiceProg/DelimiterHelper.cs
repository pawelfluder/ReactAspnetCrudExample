namespace SharpCSVServiceProg
{
    internal class DelimiterHelper
    {
        public bool CheckAndConvert(ref string inputString)
        {
            if(inputString == "" ||
                inputString == null)
            {
                return false;
            }

            if (inputString == ",")
            {
                return true;
            }

            if (inputString == "\\n")
            {
                inputString = "\n";
                return true;
            }

            if (inputString == "\\r\\n")
            {
                inputString = "\r\n";
                return true;
            }

            return false;
        }
    }
}
