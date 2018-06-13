using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test795
    {
        private readonly Mock<IClass795> aClass;

        public Test795()
        {
            this.aClass = new Mock<IClass795>();
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
