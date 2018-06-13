using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test27
    {
        private readonly Mock<IClass27> aClass;

        public Test27()
        {
            this.aClass = new Mock<IClass27>();
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
