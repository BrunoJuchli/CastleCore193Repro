using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test384
    {
        private readonly Mock<IClass384> aClass;

        public Test384()
        {
            this.aClass = new Mock<IClass384>();
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
