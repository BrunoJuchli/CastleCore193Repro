using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test717
    {
        private readonly Mock<IClass717> aClass;

        public Test717()
        {
            this.aClass = new Mock<IClass717>();
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
