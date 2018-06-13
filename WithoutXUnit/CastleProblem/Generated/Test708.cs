using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test708
    {
        private readonly Mock<IClass708> aClass;

        public Test708()
        {
            this.aClass = new Mock<IClass708>();
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
