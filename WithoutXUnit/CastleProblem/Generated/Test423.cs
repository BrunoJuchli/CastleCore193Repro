using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test423
    {
        private readonly Mock<IClass423> aClass;

        public Test423()
        {
            this.aClass = new Mock<IClass423>();
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
