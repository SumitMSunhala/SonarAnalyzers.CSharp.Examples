namespace SonarAnalyzers.Analyzers
{
    #region S1066 : Collapsible "if" statements should be merged - Non Compliant
    // https://rules.sonarsource.com/csharp/RSPEC-1066
    public class S1066NonCompliant
    {
        public static void Condition(int a)
        {
            if (a > 1)
            {
                if (a > 2)
                {
                    Console.WriteLine("Both if condition satisfied");
                }
            }
        }
    }
    #endregion

    #region S1066 : Collapsible "if" statements should be merged - Compliant
    // https://rules.sonarsource.com/csharp/RSPEC-1066
    public class S1066Compliant
    {
        public static void Condition(int a)
        {
            if (a > 1 && a > 2)
            {
                Console.WriteLine("Both if condition satisfied");
            }
        }
    }
    #endregion

}