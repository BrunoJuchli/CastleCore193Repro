using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test231
    {
        private readonly Mock<IClass231> aClass;

        public Test231()
        {
            this.aClass = new Mock<IClass231>();
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
