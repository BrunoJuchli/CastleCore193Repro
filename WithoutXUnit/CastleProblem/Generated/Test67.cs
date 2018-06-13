using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test67
    {
        private readonly Mock<IClass67> aClass;

        public Test67()
        {
            this.aClass = new Mock<IClass67>();
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
