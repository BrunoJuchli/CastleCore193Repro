using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test136
    {
        private readonly Mock<IClass136> aClass;

        public Test136()
        {
            this.aClass = new Mock<IClass136>();
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
