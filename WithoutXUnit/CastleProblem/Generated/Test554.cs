using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test554
    {
        private readonly Mock<IClass554> aClass;

        public Test554()
        {
            this.aClass = new Mock<IClass554>();
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
