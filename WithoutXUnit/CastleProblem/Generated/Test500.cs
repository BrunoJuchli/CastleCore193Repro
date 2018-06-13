using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test500
    {
        private readonly Mock<IClass500> aClass;

        public Test500()
        {
            this.aClass = new Mock<IClass500>();
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
