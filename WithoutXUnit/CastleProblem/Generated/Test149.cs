using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test149
    {
        private readonly Mock<IClass149> aClass;

        public Test149()
        {
            this.aClass = new Mock<IClass149>();
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
