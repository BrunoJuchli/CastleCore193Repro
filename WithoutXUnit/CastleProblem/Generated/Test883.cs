using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test883
    {
        private readonly Mock<IClass883> aClass;

        public Test883()
        {
            this.aClass = new Mock<IClass883>();
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
