using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test598
    {
        private readonly Mock<IClass598> aClass;

        public Test598()
        {
            this.aClass = new Mock<IClass598>();
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
