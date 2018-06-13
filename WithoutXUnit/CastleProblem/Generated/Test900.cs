using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test900
    {
        private readonly Mock<IClass900> aClass;

        public Test900()
        {
            this.aClass = new Mock<IClass900>();
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
