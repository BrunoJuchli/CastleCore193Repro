using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test758
    {
        private readonly Mock<IClass758> aClass;

        public Test758()
        {
            this.aClass = new Mock<IClass758>();
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
