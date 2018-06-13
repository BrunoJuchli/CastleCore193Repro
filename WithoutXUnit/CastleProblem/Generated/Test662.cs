using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test662
    {
        private readonly Mock<IClass662> aClass;

        public Test662()
        {
            this.aClass = new Mock<IClass662>();
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
