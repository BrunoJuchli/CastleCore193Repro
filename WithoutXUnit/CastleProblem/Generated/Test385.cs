using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test385
    {
        private readonly Mock<IClass385> aClass;

        public Test385()
        {
            this.aClass = new Mock<IClass385>();
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
