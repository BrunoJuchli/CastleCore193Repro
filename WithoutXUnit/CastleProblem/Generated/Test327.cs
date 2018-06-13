using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test327
    {
        private readonly Mock<IClass327> aClass;

        public Test327()
        {
            this.aClass = new Mock<IClass327>();
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
