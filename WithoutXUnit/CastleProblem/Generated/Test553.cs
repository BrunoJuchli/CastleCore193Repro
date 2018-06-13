using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test553
    {
        private readonly Mock<IClass553> aClass;

        public Test553()
        {
            this.aClass = new Mock<IClass553>();
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
