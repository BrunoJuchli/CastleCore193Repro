using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test316
    {
        private readonly Mock<IClass316> aClass;

        public Test316()
        {
            this.aClass = new Mock<IClass316>();
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
