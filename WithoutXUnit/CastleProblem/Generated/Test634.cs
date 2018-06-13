using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test634
    {
        private readonly Mock<IClass634> aClass;

        public Test634()
        {
            this.aClass = new Mock<IClass634>();
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
