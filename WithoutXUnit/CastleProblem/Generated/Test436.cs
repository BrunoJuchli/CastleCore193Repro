using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test436
    {
        private readonly Mock<IClass436> aClass;

        public Test436()
        {
            this.aClass = new Mock<IClass436>();
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
