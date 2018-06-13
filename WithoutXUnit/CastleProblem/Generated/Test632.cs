using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test632
    {
        private readonly Mock<IClass632> aClass;

        public Test632()
        {
            this.aClass = new Mock<IClass632>();
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
