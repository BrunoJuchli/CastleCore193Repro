using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test278
    {
        private readonly Mock<IClass278> aClass;

        public Test278()
        {
            this.aClass = new Mock<IClass278>();
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
