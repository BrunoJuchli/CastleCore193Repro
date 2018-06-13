using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test724
    {
        private readonly Mock<IClass724> aClass;

        public Test724()
        {
            this.aClass = new Mock<IClass724>();
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
