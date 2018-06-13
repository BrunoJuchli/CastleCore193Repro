using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test72
    {
        private readonly Mock<IClass72> aClass;

        public Test72()
        {
            this.aClass = new Mock<IClass72>();
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
