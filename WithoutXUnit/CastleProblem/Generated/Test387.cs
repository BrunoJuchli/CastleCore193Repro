using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test387
    {
        private readonly Mock<IClass387> aClass;

        public Test387()
        {
            this.aClass = new Mock<IClass387>();
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
