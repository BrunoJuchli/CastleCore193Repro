using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test123
    {
        private readonly Mock<IClass123> aClass;

        public Test123()
        {
            this.aClass = new Mock<IClass123>();
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
