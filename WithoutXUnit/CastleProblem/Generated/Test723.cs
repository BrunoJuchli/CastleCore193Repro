using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test723
    {
        private readonly Mock<IClass723> aClass;

        public Test723()
        {
            this.aClass = new Mock<IClass723>();
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
