using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test112
    {
        private readonly Mock<IClass112> aClass;

        public Test112()
        {
            this.aClass = new Mock<IClass112>();
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
