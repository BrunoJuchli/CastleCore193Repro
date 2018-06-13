using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test264
    {
        private readonly Mock<IClass264> aClass;

        public Test264()
        {
            this.aClass = new Mock<IClass264>();
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
