using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test34
    {
        private readonly Mock<IClass34> aClass;

        public Test34()
        {
            this.aClass = new Mock<IClass34>();
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
