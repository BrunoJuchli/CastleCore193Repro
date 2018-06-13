using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test394
    {
        private readonly Mock<IClass394> aClass;

        public Test394()
        {
            this.aClass = new Mock<IClass394>();
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
