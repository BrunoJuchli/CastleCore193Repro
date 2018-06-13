using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test929
    {
        private readonly Mock<IClass929> aClass;

        public Test929()
        {
            this.aClass = new Mock<IClass929>();
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
