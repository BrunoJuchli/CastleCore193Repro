using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test834
    {
        private readonly Mock<IClass834> aClass;

        public Test834()
        {
            this.aClass = new Mock<IClass834>();
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
