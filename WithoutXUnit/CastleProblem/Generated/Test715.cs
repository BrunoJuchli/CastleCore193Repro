using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test715
    {
        private readonly Mock<IClass715> aClass;

        public Test715()
        {
            this.aClass = new Mock<IClass715>();
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
