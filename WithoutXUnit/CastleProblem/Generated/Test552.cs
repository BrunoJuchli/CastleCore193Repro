using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test552
    {
        private readonly Mock<IClass552> aClass;

        public Test552()
        {
            this.aClass = new Mock<IClass552>();
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
