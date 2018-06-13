using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test877
    {
        private readonly Mock<IClass877> aClass;

        public Test877()
        {
            this.aClass = new Mock<IClass877>();
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
