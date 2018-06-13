using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test347
    {
        private readonly Mock<IClass347> aClass;

        public Test347()
        {
            this.aClass = new Mock<IClass347>();
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
