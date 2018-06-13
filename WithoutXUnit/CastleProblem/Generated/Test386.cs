using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test386
    {
        private readonly Mock<IClass386> aClass;

        public Test386()
        {
            this.aClass = new Mock<IClass386>();
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
