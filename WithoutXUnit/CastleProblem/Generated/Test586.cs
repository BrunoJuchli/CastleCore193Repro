using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test586
    {
        private readonly Mock<IClass586> aClass;

        public Test586()
        {
            this.aClass = new Mock<IClass586>();
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
