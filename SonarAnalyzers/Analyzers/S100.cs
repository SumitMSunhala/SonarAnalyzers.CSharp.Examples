using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonarAnalyzers.Analyzers
{
    #region S100 : Methods and properties should be named in PascalCase - Non compliant
    // https://rules.sonarsource.com/csharp/RSPEC-100
    public class S100NonCompliant
    {
        public static string? someProperty { get; set; }
        public static void doSomethingAndReturnNothing()
        {

        }
    }
    #endregion

    #region S100 : Methods and properties should be named in PascalCase - Compliant
    // https://rules.sonarsource.com/csharp/RSPEC-100
    public class S100Compliant
    {
        public static string? SomeProperty { get; set; }
        public static void DoSomethingAndReturnNothing()
        {
        }
    }
    #endregion

}