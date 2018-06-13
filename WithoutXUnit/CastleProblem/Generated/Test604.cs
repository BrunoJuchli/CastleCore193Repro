using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test604
    {
        private readonly Mock<IClass604> aClass;

        public Test604()
        {
            this.aClass = new Mock<IClass604>();
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
