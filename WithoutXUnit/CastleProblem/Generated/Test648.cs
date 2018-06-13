using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test648
    {
        private readonly Mock<IClass648> aClass;

        public Test648()
        {
            this.aClass = new Mock<IClass648>();
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
