using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test639
    {
        private readonly Mock<IClass639> aClass;

        public Test639()
        {
            this.aClass = new Mock<IClass639>();
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
