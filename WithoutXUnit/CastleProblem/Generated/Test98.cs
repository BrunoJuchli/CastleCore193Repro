using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test98
    {
        private readonly Mock<IClass98> aClass;

        public Test98()
        {
            this.aClass = new Mock<IClass98>();
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
