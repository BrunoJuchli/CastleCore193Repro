using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test195
    {
        private readonly Mock<IClass195> aClass;

        public Test195()
        {
            this.aClass = new Mock<IClass195>();
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
