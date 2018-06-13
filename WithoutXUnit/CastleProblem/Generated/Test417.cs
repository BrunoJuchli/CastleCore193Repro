using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test417
    {
        private readonly Mock<IClass417> aClass;

        public Test417()
        {
            this.aClass = new Mock<IClass417>();
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
