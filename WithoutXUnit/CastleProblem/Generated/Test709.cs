using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test709
    {
        private readonly Mock<IClass709> aClass;

        public Test709()
        {
            this.aClass = new Mock<IClass709>();
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
