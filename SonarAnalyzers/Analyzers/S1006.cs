using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonarAnalyzers.Analyzers
{
    #region S1006 : Method overrides should not change parameter defaults - Non Compliant
    // https://rules.sonarsource.com/csharp/RSPEC-1006

    public class S1006BaseNonCompliant
    {
        public virtual void Write(int i = 42)
        {
            Console.WriteLine(i);
        }
    }

    public class S1006DerivedNonCompliant : S1006BaseNonCompliant
    {
        public override void Write(int i = 5) // Noncompliant
        {
            Console.WriteLine(i);
        }
    }

    public class S1006ProgramNonCompliant
    {
        public static void Main1()
        {
            var derived = new S1006DerivedNonCompliant();
            derived.Write(); // writes 5
            Print(derived); // writes 42; was that expected?
        }

        private static void Print(S1006BaseNonCompliant item)
        {
            item.Write();
        }
    }
    #endregion

    #region S1006 : Method overrides should not change parameter defaults - Compliant
    // https://rules.sonarsource.com/csharp/RSPEC-1006

    public class S1006BaseCompliant
    {
        public virtual void Write(int i = 42)
        {
            Console.WriteLine(i);
        }
    }

    public class S1006DerivedCompliant : S1006BaseCompliant
    {
        public override void Write(int i = 42) // Compliant
        {
            Console.WriteLine(i);
        }
    }

    public class S1006ProgramCompliant
    {
        public static void Main1()
        {
            var derived = new S1006DerivedCompliant();
            derived.Write(); // writes 42
            Print(derived); // writes 42
        }

        private static void Print(S1006BaseCompliant item)
        {
            item.Write();
        }
    }
    #endregion
}