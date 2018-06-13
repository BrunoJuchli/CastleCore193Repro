using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test336
    {
        private readonly Mock<IClass336> aClass;

        public Test336()
        {
            this.aClass = new Mock<IClass336>();
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
