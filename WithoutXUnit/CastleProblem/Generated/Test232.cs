using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test232
    {
        private readonly Mock<IClass232> aClass;

        public Test232()
        {
            this.aClass = new Mock<IClass232>();
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
