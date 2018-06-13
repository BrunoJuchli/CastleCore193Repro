using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test453
    {
        private readonly Mock<IClass453> aClass;

        public Test453()
        {
            this.aClass = new Mock<IClass453>();
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
