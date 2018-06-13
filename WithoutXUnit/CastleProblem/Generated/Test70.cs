using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test70
    {
        private readonly Mock<IClass70> aClass;

        public Test70()
        {
            this.aClass = new Mock<IClass70>();
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
