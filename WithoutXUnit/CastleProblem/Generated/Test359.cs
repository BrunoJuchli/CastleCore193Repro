using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test359
    {
        private readonly Mock<IClass359> aClass;

        public Test359()
        {
            this.aClass = new Mock<IClass359>();
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
