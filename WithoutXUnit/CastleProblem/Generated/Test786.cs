using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test786
    {
        private readonly Mock<IClass786> aClass;

        public Test786()
        {
            this.aClass = new Mock<IClass786>();
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
