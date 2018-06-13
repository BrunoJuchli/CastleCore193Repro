using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test91
    {
        private readonly Mock<IClass91> aClass;

        public Test91()
        {
            this.aClass = new Mock<IClass91>();
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
