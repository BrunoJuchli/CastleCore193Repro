using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test953
    {
        private readonly Mock<IClass953> aClass;

        public Test953()
        {
            this.aClass = new Mock<IClass953>();
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
