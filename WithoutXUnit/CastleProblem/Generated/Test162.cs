using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test162
    {
        private readonly Mock<IClass162> aClass;

        public Test162()
        {
            this.aClass = new Mock<IClass162>();
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
