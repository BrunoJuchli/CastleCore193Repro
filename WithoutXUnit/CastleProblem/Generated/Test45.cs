using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test45
    {
        private readonly Mock<IClass45> aClass;

        public Test45()
        {
            this.aClass = new Mock<IClass45>();
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
