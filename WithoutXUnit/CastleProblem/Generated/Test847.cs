using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test847
    {
        private readonly Mock<IClass847> aClass;

        public Test847()
        {
            this.aClass = new Mock<IClass847>();
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
