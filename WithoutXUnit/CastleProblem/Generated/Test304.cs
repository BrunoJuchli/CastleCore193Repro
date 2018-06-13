using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test304
    {
        private readonly Mock<IClass304> aClass;

        public Test304()
        {
            this.aClass = new Mock<IClass304>();
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
