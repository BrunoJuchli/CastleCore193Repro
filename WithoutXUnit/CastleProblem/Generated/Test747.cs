using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test747
    {
        private readonly Mock<IClass747> aClass;

        public Test747()
        {
            this.aClass = new Mock<IClass747>();
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
