using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test927
    {
        private readonly Mock<IClass927> aClass;

        public Test927()
        {
            this.aClass = new Mock<IClass927>();
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
