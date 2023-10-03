using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonarAnalyzers.Analyzers
{
    #region S103 : Lines should not be too long - Non compliant

    // https://rules.sonarsource.com/csharp/RSPEC-103
    public class S103NonCompliant
    {
        // some long line should not be so long that it makes hard to read as developers have to scroll horizontally. such scrolling can frustrate the developers and they can become bad developers and they wont find good jobs outside.
    }
    #endregion

    #region S103 : Types should be named in PascalCase - Compliant
    // https://rules.sonarsource.com/csharp/RSPEC-103
    public class S103Compliant
    {
        // this is small line which is max 50 characters
        // this is not a small line but is max 100 characters which is more than above but still easy to read
    }
    #endregion

}