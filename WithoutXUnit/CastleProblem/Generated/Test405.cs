using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test405
    {
        private readonly Mock<IClass405> aClass;

        public Test405()
        {
            this.aClass = new Mock<IClass405>();
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
