using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test631
    {
        private readonly Mock<IClass631> aClass;

        public Test631()
        {
            this.aClass = new Mock<IClass631>();
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
