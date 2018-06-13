using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test733
    {
        private readonly Mock<IClass733> aClass;

        public Test733()
        {
            this.aClass = new Mock<IClass733>();
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
