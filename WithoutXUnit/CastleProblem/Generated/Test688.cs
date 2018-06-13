using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test688
    {
        private readonly Mock<IClass688> aClass;

        public Test688()
        {
            this.aClass = new Mock<IClass688>();
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
