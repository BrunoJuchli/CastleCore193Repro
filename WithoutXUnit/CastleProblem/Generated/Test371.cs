using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test371
    {
        private readonly Mock<IClass371> aClass;

        public Test371()
        {
            this.aClass = new Mock<IClass371>();
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
