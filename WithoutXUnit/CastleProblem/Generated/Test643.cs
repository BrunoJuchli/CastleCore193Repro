using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test643
    {
        private readonly Mock<IClass643> aClass;

        public Test643()
        {
            this.aClass = new Mock<IClass643>();
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
