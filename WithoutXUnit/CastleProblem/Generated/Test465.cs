using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test465
    {
        private readonly Mock<IClass465> aClass;

        public Test465()
        {
            this.aClass = new Mock<IClass465>();
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
