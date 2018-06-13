using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test567
    {
        private readonly Mock<IClass567> aClass;

        public Test567()
        {
            this.aClass = new Mock<IClass567>();
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
