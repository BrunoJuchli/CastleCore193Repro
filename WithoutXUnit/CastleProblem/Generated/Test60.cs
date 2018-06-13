using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test60
    {
        private readonly Mock<IClass60> aClass;

        public Test60()
        {
            this.aClass = new Mock<IClass60>();
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
