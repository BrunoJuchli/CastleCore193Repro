using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test831
    {
        private readonly Mock<IClass831> aClass;

        public Test831()
        {
            this.aClass = new Mock<IClass831>();
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
