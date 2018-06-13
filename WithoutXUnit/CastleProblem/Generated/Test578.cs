using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test578
    {
        private readonly Mock<IClass578> aClass;

        public Test578()
        {
            this.aClass = new Mock<IClass578>();
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
