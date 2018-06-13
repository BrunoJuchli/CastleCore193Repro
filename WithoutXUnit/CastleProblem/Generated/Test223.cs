using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test223
    {
        private readonly Mock<IClass223> aClass;

        public Test223()
        {
            this.aClass = new Mock<IClass223>();
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
