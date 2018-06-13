using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test774
    {
        private readonly Mock<IClass774> aClass;

        public Test774()
        {
            this.aClass = new Mock<IClass774>();
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
