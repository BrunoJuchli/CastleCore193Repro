using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test390
    {
        private readonly Mock<IClass390> aClass;

        public Test390()
        {
            this.aClass = new Mock<IClass390>();
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
