using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test339
    {
        private readonly Mock<IClass339> aClass;

        public Test339()
        {
            this.aClass = new Mock<IClass339>();
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
