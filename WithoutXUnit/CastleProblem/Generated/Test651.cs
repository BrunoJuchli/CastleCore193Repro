using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test651
    {
        private readonly Mock<IClass651> aClass;

        public Test651()
        {
            this.aClass = new Mock<IClass651>();
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
