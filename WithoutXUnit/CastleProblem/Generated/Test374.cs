using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test374
    {
        private readonly Mock<IClass374> aClass;

        public Test374()
        {
            this.aClass = new Mock<IClass374>();
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
