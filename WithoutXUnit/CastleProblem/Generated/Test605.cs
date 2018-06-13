using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test605
    {
        private readonly Mock<IClass605> aClass;

        public Test605()
        {
            this.aClass = new Mock<IClass605>();
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
