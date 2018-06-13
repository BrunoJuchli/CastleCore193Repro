using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test760
    {
        private readonly Mock<IClass760> aClass;

        public Test760()
        {
            this.aClass = new Mock<IClass760>();
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
