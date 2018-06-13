using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test335
    {
        private readonly Mock<IClass335> aClass;

        public Test335()
        {
            this.aClass = new Mock<IClass335>();
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
