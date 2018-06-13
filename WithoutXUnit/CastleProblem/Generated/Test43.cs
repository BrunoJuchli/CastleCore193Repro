using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test43
    {
        private readonly Mock<IClass43> aClass;

        public Test43()
        {
            this.aClass = new Mock<IClass43>();
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
