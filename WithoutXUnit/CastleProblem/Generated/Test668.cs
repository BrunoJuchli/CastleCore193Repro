using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test668
    {
        private readonly Mock<IClass668> aClass;

        public Test668()
        {
            this.aClass = new Mock<IClass668>();
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
