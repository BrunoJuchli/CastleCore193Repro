using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test479
    {
        private readonly Mock<IClass479> aClass;

        public Test479()
        {
            this.aClass = new Mock<IClass479>();
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
