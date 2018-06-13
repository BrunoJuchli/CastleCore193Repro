using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test365
    {
        private readonly Mock<IClass365> aClass;

        public Test365()
        {
            this.aClass = new Mock<IClass365>();
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
