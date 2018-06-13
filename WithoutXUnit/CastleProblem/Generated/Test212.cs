using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test212
    {
        private readonly Mock<IClass212> aClass;

        public Test212()
        {
            this.aClass = new Mock<IClass212>();
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
