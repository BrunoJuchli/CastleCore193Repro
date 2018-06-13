using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test881
    {
        private readonly Mock<IClass881> aClass;

        public Test881()
        {
            this.aClass = new Mock<IClass881>();
        }

        public void DoSomething()
        {
            try
            {
                this.aClass.Setup(x => x.DoSomething()).Returns(true);
                bool result = this.aClass.Object.DoSomething();
            }
            catch (BadImageFormatException)
            {
                Debugger.Launch();
            }
        }
    }
}
