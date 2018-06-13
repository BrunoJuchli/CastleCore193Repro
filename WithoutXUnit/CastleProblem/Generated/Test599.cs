using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test599
    {
        private readonly Mock<IClass599> aClass;

        public Test599()
        {
            this.aClass = new Mock<IClass599>();
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
