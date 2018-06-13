using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test642
    {
        private readonly Mock<IClass642> aClass;

        public Test642()
        {
            this.aClass = new Mock<IClass642>();
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
