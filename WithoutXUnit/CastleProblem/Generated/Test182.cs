using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test182
    {
        private readonly Mock<IClass182> aClass;

        public Test182()
        {
            this.aClass = new Mock<IClass182>();
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
