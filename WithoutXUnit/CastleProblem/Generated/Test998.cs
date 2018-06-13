using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test998
    {
        private readonly Mock<IClass998> aClass;

        public Test998()
        {
            this.aClass = new Mock<IClass998>();
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
