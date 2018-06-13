using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test581
    {
        private readonly Mock<IClass581> aClass;

        public Test581()
        {
            this.aClass = new Mock<IClass581>();
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
