using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test949
    {
        private readonly Mock<IClass949> aClass;

        public Test949()
        {
            this.aClass = new Mock<IClass949>();
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
