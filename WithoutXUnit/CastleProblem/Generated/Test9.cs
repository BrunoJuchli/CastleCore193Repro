using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test9
    {
        private readonly Mock<IClass9> aClass;

        public Test9()
        {
            this.aClass = new Mock<IClass9>();
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
