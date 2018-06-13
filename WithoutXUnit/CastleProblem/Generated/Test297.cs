using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test297
    {
        private readonly Mock<IClass297> aClass;

        public Test297()
        {
            this.aClass = new Mock<IClass297>();
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
