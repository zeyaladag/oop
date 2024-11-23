namespace October21.UI.View
{
    internal static class TerminalUI
    {
        /* SplashScreen is a method that does not take any parameters and return any values.
         * since main method is defined as static, SplashScreen should also define as static in order to be called in the program.
         * 
         * we can differentiate a method by changing the parameter structure and call it with the same name. it is called overloading.
         * overloading requires changing the parameter number or parameter type. it is called method signature. 
         * 
         * every class member is private by default.
         * we can define private, public, internal, protected and protected internal access modifiers.
         * 
         * collecting types with same purposes such as class, struct, enum, interface, delegate 
         * under the same namespace ensures integrity.
         * 
         * note that Console class is a dependency of TerminalUI class.
         * terminal is a environment to interact with user. 
         * every instrument that helps UI-related jobs are collected under View.
         * examples are MVC (model view controller) or MVVM (model view view model)
         */

        internal static void SplashScreen()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("************************");
            Console.WriteLine("****Welcome Stranger****");
            Console.WriteLine("************************");
            Console.ForegroundColor = ConsoleColor.White;
        }
        internal static void SplashScreen(string playerName)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            //trying our own GetSmartText method
            Console.Write(GetSmartText('+', 24));
            Console.WriteLine("Welcome {0}", playerName);
            Console.WriteLine("************************");
            Console.WriteLine(new String('*', 24));
        }
        static string GetSmartText(char c, int count)
        {
            string result = string.Empty;
            for (int i = 0; i < count; i++)
            {
                result += c;
            }
            result += "\n";
            return result;
        }
    }
}