using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test499
    {
        private readonly Mock<IClass499> aClass;

        public Test499()
        {
            this.aClass = new Mock<IClass499>();
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
