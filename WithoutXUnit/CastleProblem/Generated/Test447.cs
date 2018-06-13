using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test447
    {
        private readonly Mock<IClass447> aClass;

        public Test447()
        {
            this.aClass = new Mock<IClass447>();
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
