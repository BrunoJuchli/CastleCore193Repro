using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test382
    {
        private readonly Mock<IClass382> aClass;

        public Test382()
        {
            this.aClass = new Mock<IClass382>();
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
