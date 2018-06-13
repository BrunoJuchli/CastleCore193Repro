using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test458
    {
        private readonly Mock<IClass458> aClass;

        public Test458()
        {
            this.aClass = new Mock<IClass458>();
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
