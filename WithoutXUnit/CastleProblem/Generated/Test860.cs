using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test860
    {
        private readonly Mock<IClass860> aClass;

        public Test860()
        {
            this.aClass = new Mock<IClass860>();
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
