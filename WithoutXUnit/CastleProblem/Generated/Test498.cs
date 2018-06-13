using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test498
    {
        private readonly Mock<IClass498> aClass;

        public Test498()
        {
            this.aClass = new Mock<IClass498>();
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
