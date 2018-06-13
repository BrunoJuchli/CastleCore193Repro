using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test250
    {
        private readonly Mock<IClass250> aClass;

        public Test250()
        {
            this.aClass = new Mock<IClass250>();
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
