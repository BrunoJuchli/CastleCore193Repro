using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test809
    {
        private readonly Mock<IClass809> aClass;

        public Test809()
        {
            this.aClass = new Mock<IClass809>();
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
