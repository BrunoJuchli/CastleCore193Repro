using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test131
    {
        private readonly Mock<IClass131> aClass;

        public Test131()
        {
            this.aClass = new Mock<IClass131>();
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
