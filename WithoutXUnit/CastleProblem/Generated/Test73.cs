using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test73
    {
        private readonly Mock<IClass73> aClass;

        public Test73()
        {
            this.aClass = new Mock<IClass73>();
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
