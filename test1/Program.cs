namespace test1
{
    internal static class Program
    {
        static void Main()
        {
            string windowTitle = "title";
            string labelName = "label";

            ApplicationConfiguration.Initialize();
            Application.Run(new window(windowTitle, labelName));
        }
    }
}