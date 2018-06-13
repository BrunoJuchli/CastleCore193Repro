using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test818
    {
        private readonly Mock<IClass818> aClass;

        public Test818()
        {
            this.aClass = new Mock<IClass818>();
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
