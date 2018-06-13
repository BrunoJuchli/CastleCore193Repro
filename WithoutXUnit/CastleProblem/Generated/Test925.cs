using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test925
    {
        private readonly Mock<IClass925> aClass;

        public Test925()
        {
            this.aClass = new Mock<IClass925>();
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
