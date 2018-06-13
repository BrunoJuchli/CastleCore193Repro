using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test481
    {
        private readonly Mock<IClass481> aClass;

        public Test481()
        {
            this.aClass = new Mock<IClass481>();
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
