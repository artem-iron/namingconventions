namespace thisShouldBePascalCaseNamespace
{
    internal interface thisShouldBeIPascalCaseInterface
    {
        void thisShouldBePascalCaseMethod(string ThisShouldBeCamelCase, int ThisShouldBeCamelCaseToo);
    }

    internal class thisShouldBePascalCaseClass
    {
        public const string thisShouldBeAllCapsWithUndersores = "fileName";
        private const string thisShouldBeAllCapsWithUndersores2 = "fileName2";
        internal const string thisShouldBeAllCapsWithUndersores3 = "fileName3";
        public static string thisShouldBeSUndersocrePascalCase = "fileName4";
        private static readonly string thisShouldBeSUndersocreCamelCase = "fileName5";
        internal static string thisShouldBeSUndersocreCamelCase2 = "fileName6";
        public string thisShouldBePascalCase = "fileName7";
        private readonly string thisShouldBeUnderscoreCamelCase = "fileName8";
        internal string thisShouldBeUnderscoreCamelCase2 = "fileName9";

        public string thisShouldBePascalCase2
        {
            get => "fileName10";
            set => thisShouldBeUnderscoreCamelCase2 = value;
        }

        private string thisShouldBeUnderscoreCamelCase3
        {
            get => "fileName11";
            set => thisShouldBeUnderscoreCamelCase2 = value;
        }

        internal string thisShouldBeUnderscoreCamelCase4
        {
            get => "fileName12";
            set => thisShouldBeUnderscoreCamelCase2 = value;
        }

        public static string thisShouldbeSUndersocrePascalCase { get; set; } = "fileName13";

        public thisShouldBePascalCaseClass()
        {
            Console.WriteLine(thisShouldBeAllCapsWithUndersores);
            Console.WriteLine(thisShouldBeAllCapsWithUndersores2);
            Console.WriteLine(thisShouldBeAllCapsWithUndersores3);
            Console.WriteLine(thisShouldBeSUndersocreCamelCase);
            Console.WriteLine(thisShouldBeSUndersocreCamelCase2);
            Console.WriteLine(thisShouldBePascalCase);
            Console.WriteLine(thisShouldBeUnderscoreCamelCase);
            Console.WriteLine(thisShouldBeUnderscoreCamelCase2);
            Console.WriteLine(thisShouldBePascalCase2);
            Console.WriteLine(thisShouldBeUnderscoreCamelCase3);
            Console.WriteLine(thisShouldBeUnderscoreCamelCase4);
            Console.WriteLine(thisShouldbeSUndersocrePascalCase);
            thisShouldBePascalCaseMethod2();
            _ = thisShouldBePascalCaseAsyncMethod();
        }

        private static async Task thisShouldBePascalCaseAsyncMethod()
        {
            await Task.Delay(0);
        }

        public static void thisShouldBePascalCaseMethod(string ThisShouldBeCamelCase, int ThisShouldBeCamelCaseToo)
        {
            _ = ThisShouldBeCamelCase + ThisShouldBeCamelCaseToo;
            string ThisShouldBeCamelCase3 = ThisShouldBeCamelCase + ThisShouldBeCamelCaseToo;
            Console.WriteLine(ThisShouldBeCamelCase3);
        }

        private static void thisShouldBePascalCaseMethod2()
        {

        }
    }

    public enum thisShouldBePascalCaseEnum
    {
        thisShouldBePascalCaseEnumEntry = 0
    }
}
