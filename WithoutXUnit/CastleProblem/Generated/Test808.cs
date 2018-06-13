using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test808
    {
        private readonly Mock<IClass808> aClass;

        public Test808()
        {
            this.aClass = new Mock<IClass808>();
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
