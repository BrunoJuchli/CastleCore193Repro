using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test623
    {
        private readonly Mock<IClass623> aClass;

        public Test623()
        {
            this.aClass = new Mock<IClass623>();
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
