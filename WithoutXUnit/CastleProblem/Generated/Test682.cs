using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test682
    {
        private readonly Mock<IClass682> aClass;

        public Test682()
        {
            this.aClass = new Mock<IClass682>();
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
