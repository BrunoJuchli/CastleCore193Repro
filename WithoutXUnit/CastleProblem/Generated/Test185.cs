using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test185
    {
        private readonly Mock<IClass185> aClass;

        public Test185()
        {
            this.aClass = new Mock<IClass185>();
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
