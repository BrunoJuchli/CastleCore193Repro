using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test325
    {
        private readonly Mock<IClass325> aClass;

        public Test325()
        {
            this.aClass = new Mock<IClass325>();
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
