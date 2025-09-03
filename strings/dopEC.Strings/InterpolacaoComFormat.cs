namespace dopEC.Strings
{
    public class InterpolacaoComFormat
    {
        public static void stringComFormat(string text)
        {
            Console.Write("Interpolação de String c/ `Format`: ");
            Console.WriteLine(string.Format("{0}", text));
        }
    }
}
