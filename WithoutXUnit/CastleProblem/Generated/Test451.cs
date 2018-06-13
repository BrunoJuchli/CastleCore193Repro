using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test451
    {
        private readonly Mock<IClass451> aClass;

        public Test451()
        {
            this.aClass = new Mock<IClass451>();
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
