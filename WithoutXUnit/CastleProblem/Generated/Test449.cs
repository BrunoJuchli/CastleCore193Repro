using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test449
    {
        private readonly Mock<IClass449> aClass;

        public Test449()
        {
            this.aClass = new Mock<IClass449>();
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
