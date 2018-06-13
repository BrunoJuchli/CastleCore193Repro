using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test766
    {
        private readonly Mock<IClass766> aClass;

        public Test766()
        {
            this.aClass = new Mock<IClass766>();
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
