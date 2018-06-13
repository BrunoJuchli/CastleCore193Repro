using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test750
    {
        private readonly Mock<IClass750> aClass;

        public Test750()
        {
            this.aClass = new Mock<IClass750>();
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
