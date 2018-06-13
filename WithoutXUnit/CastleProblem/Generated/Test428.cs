using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test428
    {
        private readonly Mock<IClass428> aClass;

        public Test428()
        {
            this.aClass = new Mock<IClass428>();
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
