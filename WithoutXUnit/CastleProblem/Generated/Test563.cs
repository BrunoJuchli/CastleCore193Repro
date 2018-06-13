using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test563
    {
        private readonly Mock<IClass563> aClass;

        public Test563()
        {
            this.aClass = new Mock<IClass563>();
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
