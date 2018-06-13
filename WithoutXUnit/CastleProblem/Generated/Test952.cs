using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test952
    {
        private readonly Mock<IClass952> aClass;

        public Test952()
        {
            this.aClass = new Mock<IClass952>();
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
