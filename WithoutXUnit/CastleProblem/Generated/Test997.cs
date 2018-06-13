using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test997
    {
        private readonly Mock<IClass997> aClass;

        public Test997()
        {
            this.aClass = new Mock<IClass997>();
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
