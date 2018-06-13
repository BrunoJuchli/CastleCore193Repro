using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test692
    {
        private readonly Mock<IClass692> aClass;

        public Test692()
        {
            this.aClass = new Mock<IClass692>();
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
