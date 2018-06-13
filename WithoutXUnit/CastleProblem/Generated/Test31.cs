using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test31
    {
        private readonly Mock<IClass31> aClass;

        public Test31()
        {
            this.aClass = new Mock<IClass31>();
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
