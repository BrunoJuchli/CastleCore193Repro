using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test670
    {
        private readonly Mock<IClass670> aClass;

        public Test670()
        {
            this.aClass = new Mock<IClass670>();
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
