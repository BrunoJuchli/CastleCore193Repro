using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test53
    {
        private readonly Mock<IClass53> aClass;

        public Test53()
        {
            this.aClass = new Mock<IClass53>();
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
