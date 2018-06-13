using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test194
    {
        private readonly Mock<IClass194> aClass;

        public Test194()
        {
            this.aClass = new Mock<IClass194>();
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
