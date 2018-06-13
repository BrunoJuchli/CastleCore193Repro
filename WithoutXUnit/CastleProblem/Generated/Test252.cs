using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test252
    {
        private readonly Mock<IClass252> aClass;

        public Test252()
        {
            this.aClass = new Mock<IClass252>();
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
