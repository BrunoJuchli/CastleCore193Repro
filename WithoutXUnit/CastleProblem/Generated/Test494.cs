using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test494
    {
        private readonly Mock<IClass494> aClass;

        public Test494()
        {
            this.aClass = new Mock<IClass494>();
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
