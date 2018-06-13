using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test780
    {
        private readonly Mock<IClass780> aClass;

        public Test780()
        {
            this.aClass = new Mock<IClass780>();
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
