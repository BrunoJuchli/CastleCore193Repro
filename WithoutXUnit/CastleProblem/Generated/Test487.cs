using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test487
    {
        private readonly Mock<IClass487> aClass;

        public Test487()
        {
            this.aClass = new Mock<IClass487>();
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
