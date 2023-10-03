namespace SonarAnalyzers.Analyzers
{
    #region S1048 : Finalizers should not throw exceptions - Non Compliant
    // https://rules.sonarsource.com/csharp/RSPEC-1048
    public class S1048NonCompliant
    {
        ~S1048NonCompliant()
        {
            throw new ArgumentException("some exception for S1048");
        }
    }
    #endregion

    #region S1048 : Finalizers should not throw exceptions - Compliant
    // https://rules.sonarsource.com/csharp/RSPEC-1048
    public class S1048Compliant
    {
        ~S1048Compliant()
        {
        }
    }
    #endregion
}