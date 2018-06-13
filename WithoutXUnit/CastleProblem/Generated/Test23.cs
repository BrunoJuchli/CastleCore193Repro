using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test23
    {
        private readonly Mock<IClass23> aClass;

        public Test23()
        {
            this.aClass = new Mock<IClass23>();
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
