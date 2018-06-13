using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test464
    {
        private readonly Mock<IClass464> aClass;

        public Test464()
        {
            this.aClass = new Mock<IClass464>();
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
