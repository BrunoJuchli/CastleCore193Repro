using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test433
    {
        private readonly Mock<IClass433> aClass;

        public Test433()
        {
            this.aClass = new Mock<IClass433>();
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
