using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test788
    {
        private readonly Mock<IClass788> aClass;

        public Test788()
        {
            this.aClass = new Mock<IClass788>();
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
