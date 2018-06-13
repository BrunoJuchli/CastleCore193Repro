using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test840
    {
        private readonly Mock<IClass840> aClass;

        public Test840()
        {
            this.aClass = new Mock<IClass840>();
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
