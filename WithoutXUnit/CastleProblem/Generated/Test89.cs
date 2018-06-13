using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test89
    {
        private readonly Mock<IClass89> aClass;

        public Test89()
        {
            this.aClass = new Mock<IClass89>();
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
