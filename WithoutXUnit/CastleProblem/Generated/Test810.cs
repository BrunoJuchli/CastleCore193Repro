using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test810
    {
        private readonly Mock<IClass810> aClass;

        public Test810()
        {
            this.aClass = new Mock<IClass810>();
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
