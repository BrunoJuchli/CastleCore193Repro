using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test630
    {
        private readonly Mock<IClass630> aClass;

        public Test630()
        {
            this.aClass = new Mock<IClass630>();
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
