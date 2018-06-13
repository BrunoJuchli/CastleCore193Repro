using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test680
    {
        private readonly Mock<IClass680> aClass;

        public Test680()
        {
            this.aClass = new Mock<IClass680>();
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
