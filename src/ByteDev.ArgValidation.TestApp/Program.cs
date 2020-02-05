namespace ByteDev.ArgValidation.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MustBeGreaterThan(1);
        }

        private static void MustBeGreaterThan(int count)
        {
            ArgValidator.GreaterThan(count, 2, nameof(count));
        }
    }
}
