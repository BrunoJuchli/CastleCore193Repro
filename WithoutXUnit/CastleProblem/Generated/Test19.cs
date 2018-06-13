using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test19
    {
        private readonly Mock<IClass19> aClass;

        public Test19()
        {
            this.aClass = new Mock<IClass19>();
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
