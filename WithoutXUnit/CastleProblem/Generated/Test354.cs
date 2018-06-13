using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test354
    {
        private readonly Mock<IClass354> aClass;

        public Test354()
        {
            this.aClass = new Mock<IClass354>();
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
