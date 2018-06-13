using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test899
    {
        private readonly Mock<IClass899> aClass;

        public Test899()
        {
            this.aClass = new Mock<IClass899>();
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
