using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test407
    {
        private readonly Mock<IClass407> aClass;

        public Test407()
        {
            this.aClass = new Mock<IClass407>();
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
