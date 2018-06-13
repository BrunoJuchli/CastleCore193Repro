using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test602
    {
        private readonly Mock<IClass602> aClass;

        public Test602()
        {
            this.aClass = new Mock<IClass602>();
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
