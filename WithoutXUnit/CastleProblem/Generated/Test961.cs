using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test961
    {
        private readonly Mock<IClass961> aClass;

        public Test961()
        {
            this.aClass = new Mock<IClass961>();
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
