namespace dopEC.Strings
{
    public class InterpolacaoComFormat
    {
        public static void stringComFormat(StringEntity text)
        {
            Console.Write("Interpolação de String c/ `Format`: ");
            Console.WriteLine(string.Format("{0}", text.Text));
        }
    }
}
