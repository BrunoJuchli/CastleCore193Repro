using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test101
    {
        private readonly Mock<IClass101> aClass;

        public Test101()
        {
            this.aClass = new Mock<IClass101>();
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
