using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test282
    {
        private readonly Mock<IClass282> aClass;

        public Test282()
        {
            this.aClass = new Mock<IClass282>();
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
