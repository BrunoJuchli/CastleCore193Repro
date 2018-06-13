using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test46
    {
        private readonly Mock<IClass46> aClass;

        public Test46()
        {
            this.aClass = new Mock<IClass46>();
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
