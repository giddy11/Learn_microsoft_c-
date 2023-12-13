namespace StaticClasses
{
    internal class DefiningTypes
    {
    }

    static class Constants
    {
        // i can make a static constructor but i can't create an instance of a class
        // you can use static constructors on instance classes
        static Constants()
        {
            connectionString = "Server=..."; //config
        }

        public static DateTime GetDateTimeFromDateOnly(DateOnly input)
        {
            return new DateTime(input.Year, input.Month, input.Day);
        }

        private static string connectionString;
        public static readonly string CONFIG_SERVER_NAME = "TargetServer";
        public const string CONFIG_DB_NAME = "DatabaseName";

        public static int MyProperty { get; set; }
    }
}
