using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test779
    {
        private readonly Mock<IClass779> aClass;

        public Test779()
        {
            this.aClass = new Mock<IClass779>();
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
