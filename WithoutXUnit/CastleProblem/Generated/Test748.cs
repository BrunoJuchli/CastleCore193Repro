using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test748
    {
        private readonly Mock<IClass748> aClass;

        public Test748()
        {
            this.aClass = new Mock<IClass748>();
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
