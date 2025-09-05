namespace dopEC.Strings
{
    public class StringEntity
    {
        public string Text { get; set; } = string.Empty;

        public override string ToString()
        {
            return Text;
        }
    }
}
