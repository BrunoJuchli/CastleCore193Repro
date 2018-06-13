using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test279
    {
        private readonly Mock<IClass279> aClass;

        public Test279()
        {
            this.aClass = new Mock<IClass279>();
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
