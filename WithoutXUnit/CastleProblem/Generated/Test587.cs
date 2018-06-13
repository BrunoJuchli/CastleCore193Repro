using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test587
    {
        private readonly Mock<IClass587> aClass;

        public Test587()
        {
            this.aClass = new Mock<IClass587>();
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
