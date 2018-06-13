using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test157
    {
        private readonly Mock<IClass157> aClass;

        public Test157()
        {
            this.aClass = new Mock<IClass157>();
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
