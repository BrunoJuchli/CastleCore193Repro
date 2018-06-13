using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test635
    {
        private readonly Mock<IClass635> aClass;

        public Test635()
        {
            this.aClass = new Mock<IClass635>();
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
