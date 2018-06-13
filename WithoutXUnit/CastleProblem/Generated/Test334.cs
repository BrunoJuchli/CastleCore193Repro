using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test334
    {
        private readonly Mock<IClass334> aClass;

        public Test334()
        {
            this.aClass = new Mock<IClass334>();
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
