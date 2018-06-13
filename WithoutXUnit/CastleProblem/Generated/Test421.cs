using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test421
    {
        private readonly Mock<IClass421> aClass;

        public Test421()
        {
            this.aClass = new Mock<IClass421>();
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
