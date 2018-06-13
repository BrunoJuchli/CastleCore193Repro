using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test559
    {
        private readonly Mock<IClass559> aClass;

        public Test559()
        {
            this.aClass = new Mock<IClass559>();
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
