using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test986
    {
        private readonly Mock<IClass986> aClass;

        public Test986()
        {
            this.aClass = new Mock<IClass986>();
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
