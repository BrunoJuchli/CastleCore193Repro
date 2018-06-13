using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test243
    {
        private readonly Mock<IClass243> aClass;

        public Test243()
        {
            this.aClass = new Mock<IClass243>();
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
