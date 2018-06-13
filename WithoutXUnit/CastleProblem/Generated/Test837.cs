using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test837
    {
        private readonly Mock<IClass837> aClass;

        public Test837()
        {
            this.aClass = new Mock<IClass837>();
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
