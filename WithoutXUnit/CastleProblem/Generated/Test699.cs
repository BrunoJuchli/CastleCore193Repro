using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test699
    {
        private readonly Mock<IClass699> aClass;

        public Test699()
        {
            this.aClass = new Mock<IClass699>();
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
