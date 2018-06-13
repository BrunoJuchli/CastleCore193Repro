using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test475
    {
        private readonly Mock<IClass475> aClass;

        public Test475()
        {
            this.aClass = new Mock<IClass475>();
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
