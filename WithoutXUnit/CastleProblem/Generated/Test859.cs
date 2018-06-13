using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test859
    {
        private readonly Mock<IClass859> aClass;

        public Test859()
        {
            this.aClass = new Mock<IClass859>();
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
