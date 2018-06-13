using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test129
    {
        private readonly Mock<IClass129> aClass;

        public Test129()
        {
            this.aClass = new Mock<IClass129>();
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
