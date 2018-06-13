using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test219
    {
        private readonly Mock<IClass219> aClass;

        public Test219()
        {
            this.aClass = new Mock<IClass219>();
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
