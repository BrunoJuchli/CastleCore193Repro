using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test805
    {
        private readonly Mock<IClass805> aClass;

        public Test805()
        {
            this.aClass = new Mock<IClass805>();
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
