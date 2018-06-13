using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test753
    {
        private readonly Mock<IClass753> aClass;

        public Test753()
        {
            this.aClass = new Mock<IClass753>();
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
