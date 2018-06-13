using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test503
    {
        private readonly Mock<IClass503> aClass;

        public Test503()
        {
            this.aClass = new Mock<IClass503>();
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
