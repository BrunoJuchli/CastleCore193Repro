using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test887
    {
        private readonly Mock<IClass887> aClass;

        public Test887()
        {
            this.aClass = new Mock<IClass887>();
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
