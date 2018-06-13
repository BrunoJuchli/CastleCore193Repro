using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test324
    {
        private readonly Mock<IClass324> aClass;

        public Test324()
        {
            this.aClass = new Mock<IClass324>();
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
