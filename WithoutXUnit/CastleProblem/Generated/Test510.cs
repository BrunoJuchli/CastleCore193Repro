using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test510
    {
        private readonly Mock<IClass510> aClass;

        public Test510()
        {
            this.aClass = new Mock<IClass510>();
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
