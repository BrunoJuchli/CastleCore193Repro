using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test653
    {
        private readonly Mock<IClass653> aClass;

        public Test653()
        {
            this.aClass = new Mock<IClass653>();
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
