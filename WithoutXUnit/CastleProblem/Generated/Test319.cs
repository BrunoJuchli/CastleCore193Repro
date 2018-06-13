using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test319
    {
        private readonly Mock<IClass319> aClass;

        public Test319()
        {
            this.aClass = new Mock<IClass319>();
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
