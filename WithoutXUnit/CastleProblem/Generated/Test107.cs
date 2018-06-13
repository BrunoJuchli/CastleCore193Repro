using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test107
    {
        private readonly Mock<IClass107> aClass;

        public Test107()
        {
            this.aClass = new Mock<IClass107>();
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
