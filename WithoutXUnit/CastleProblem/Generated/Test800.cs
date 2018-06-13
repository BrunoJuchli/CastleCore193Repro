using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test800
    {
        private readonly Mock<IClass800> aClass;

        public Test800()
        {
            this.aClass = new Mock<IClass800>();
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
