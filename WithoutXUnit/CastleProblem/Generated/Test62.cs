using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test62
    {
        private readonly Mock<IClass62> aClass;

        public Test62()
        {
            this.aClass = new Mock<IClass62>();
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
