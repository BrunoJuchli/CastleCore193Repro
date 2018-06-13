using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test450
    {
        private readonly Mock<IClass450> aClass;

        public Test450()
        {
            this.aClass = new Mock<IClass450>();
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
