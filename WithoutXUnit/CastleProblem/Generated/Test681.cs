using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test681
    {
        private readonly Mock<IClass681> aClass;

        public Test681()
        {
            this.aClass = new Mock<IClass681>();
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
