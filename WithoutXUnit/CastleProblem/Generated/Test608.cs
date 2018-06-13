using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test608
    {
        private readonly Mock<IClass608> aClass;

        public Test608()
        {
            this.aClass = new Mock<IClass608>();
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
