using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test626
    {
        private readonly Mock<IClass626> aClass;

        public Test626()
        {
            this.aClass = new Mock<IClass626>();
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
