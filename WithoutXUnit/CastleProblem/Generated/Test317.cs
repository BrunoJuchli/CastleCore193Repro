using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test317
    {
        private readonly Mock<IClass317> aClass;

        public Test317()
        {
            this.aClass = new Mock<IClass317>();
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
