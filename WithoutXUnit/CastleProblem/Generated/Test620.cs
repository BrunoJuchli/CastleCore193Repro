using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test620
    {
        private readonly Mock<IClass620> aClass;

        public Test620()
        {
            this.aClass = new Mock<IClass620>();
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
