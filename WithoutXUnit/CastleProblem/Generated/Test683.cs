using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test683
    {
        private readonly Mock<IClass683> aClass;

        public Test683()
        {
            this.aClass = new Mock<IClass683>();
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
