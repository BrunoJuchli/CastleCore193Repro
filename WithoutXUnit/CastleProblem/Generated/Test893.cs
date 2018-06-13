using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test893
    {
        private readonly Mock<IClass893> aClass;

        public Test893()
        {
            this.aClass = new Mock<IClass893>();
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
