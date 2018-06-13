using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test442
    {
        private readonly Mock<IClass442> aClass;

        public Test442()
        {
            this.aClass = new Mock<IClass442>();
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
