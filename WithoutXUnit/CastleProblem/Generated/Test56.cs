using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test56
    {
        private readonly Mock<IClass56> aClass;

        public Test56()
        {
            this.aClass = new Mock<IClass56>();
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
