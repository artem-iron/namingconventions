namespace ThisShouldBePascalCaseNamespace
{
    internal interface IThisShouldBeIPascalCaseInterface
    {
        void ThisShouldBePascalCaseMethod(string thisShouldBeCamelCase, int thisShouldBeCamelCaseToo);
    }

    internal class ThisShouldBePascalCaseClass
    {
        public const string THIS_SHOULD_BE_ALL_CAPS_WITH_UNDERSORES = "fileName";
        private const string THIS_SHOULD_BE_ALL_CAPS_WITH_UNDERSORES_2 = "fileName2";
        internal const string THIS_SHOULD_BE_ALL_CAPS_WITH_UNDERSORES_3 = "fileName3";
        public static string s_ThisShouldBeSUndersocrePascalCase = "fileName4";
        private static readonly string s_thisShouldBeSUndersocreCamelCase = "fileName5";
        internal static string s_thisShouldBeSUndersocreCamelCase2 = "fileName6";
        public string ThisShouldBePascalCase = "fileName7";
        private readonly string _thisShouldBeUnderscoreCamelCase = "fileName8";
        internal string _thisShouldBeUnderscoreCamelCase2 = "fileName9";

        public string ThisShouldBePascalCase2
        {
            get => "fileName10";
            set => _thisShouldBeUnderscoreCamelCase2 = value;
        }

        private string _thisShouldBeUnderscoreCamelCase3
        {
            get => "fileName11";
            set => _thisShouldBeUnderscoreCamelCase2 = value;
        }

        internal string _thisShouldBeUnderscoreCamelCase4
        {
            get => "fileName12";
            set => _thisShouldBeUnderscoreCamelCase2 = value;
        }

        public static string s_ThisShouldbeSUndersocrePascalCase { get; set; } = "fileName13";

        public ThisShouldBePascalCaseClass()
        {
            Console.WriteLine(THIS_SHOULD_BE_ALL_CAPS_WITH_UNDERSORES);
            Console.WriteLine(THIS_SHOULD_BE_ALL_CAPS_WITH_UNDERSORES_2);
            Console.WriteLine(THIS_SHOULD_BE_ALL_CAPS_WITH_UNDERSORES_3);
            Console.WriteLine(s_thisShouldBeSUndersocreCamelCase);
            Console.WriteLine(s_thisShouldBeSUndersocreCamelCase2);
            Console.WriteLine(ThisShouldBePascalCase);
            Console.WriteLine(_thisShouldBeUnderscoreCamelCase);
            Console.WriteLine(_thisShouldBeUnderscoreCamelCase2);
            Console.WriteLine(ThisShouldBePascalCase2);
            Console.WriteLine(_thisShouldBeUnderscoreCamelCase3);
            Console.WriteLine(_thisShouldBeUnderscoreCamelCase4);
            Console.WriteLine(s_ThisShouldbeSUndersocrePascalCase);
            ThisShouldBePascalCaseMethod2();
            _ = ThisShouldBePascalCaseAsyncMethodAsync();
        }

        private static async Task ThisShouldBePascalCaseAsyncMethodAsync()
        {
            await Task.Delay(0);
        }

        public static void ThisShouldBePascalCaseMethod(string thisShouldBeCamelCase, int thisShouldBeCamelCaseToo)
        {
            _ = thisShouldBeCamelCase + thisShouldBeCamelCaseToo;
            string thisShouldBeCamelCase3 = thisShouldBeCamelCase + thisShouldBeCamelCaseToo;
            Console.WriteLine(thisShouldBeCamelCase3);
        }

        private static void ThisShouldBePascalCaseMethod2()
        {

        }
    }

    public enum ThisShouldBePascalCaseEnum2
    {
        ThisShouldBePascalCaseEnumEntry = 0
    }
}
