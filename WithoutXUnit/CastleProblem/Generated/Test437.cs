using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test437
    {
        private readonly Mock<IClass437> aClass;

        public Test437()
        {
            this.aClass = new Mock<IClass437>();
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
