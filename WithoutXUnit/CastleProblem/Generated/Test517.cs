using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test517
    {
        private readonly Mock<IClass517> aClass;

        public Test517()
        {
            this.aClass = new Mock<IClass517>();
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
