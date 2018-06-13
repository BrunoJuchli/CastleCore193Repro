using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test92
    {
        private readonly Mock<IClass92> aClass;

        public Test92()
        {
            this.aClass = new Mock<IClass92>();
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
