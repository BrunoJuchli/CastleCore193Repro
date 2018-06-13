using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test17
    {
        private readonly Mock<IClass17> aClass;

        public Test17()
        {
            this.aClass = new Mock<IClass17>();
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
