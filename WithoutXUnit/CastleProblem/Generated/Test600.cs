using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test600
    {
        private readonly Mock<IClass600> aClass;

        public Test600()
        {
            this.aClass = new Mock<IClass600>();
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
