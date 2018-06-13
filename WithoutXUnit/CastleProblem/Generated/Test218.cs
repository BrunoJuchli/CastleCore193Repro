using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test218
    {
        private readonly Mock<IClass218> aClass;

        public Test218()
        {
            this.aClass = new Mock<IClass218>();
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
