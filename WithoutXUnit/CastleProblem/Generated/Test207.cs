using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test207
    {
        private readonly Mock<IClass207> aClass;

        public Test207()
        {
            this.aClass = new Mock<IClass207>();
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
