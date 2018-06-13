using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test262
    {
        private readonly Mock<IClass262> aClass;

        public Test262()
        {
            this.aClass = new Mock<IClass262>();
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
