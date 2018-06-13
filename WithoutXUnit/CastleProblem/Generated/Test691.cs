using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test691
    {
        private readonly Mock<IClass691> aClass;

        public Test691()
        {
            this.aClass = new Mock<IClass691>();
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
