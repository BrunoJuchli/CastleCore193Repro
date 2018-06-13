using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test531
    {
        private readonly Mock<IClass531> aClass;

        public Test531()
        {
            this.aClass = new Mock<IClass531>();
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
