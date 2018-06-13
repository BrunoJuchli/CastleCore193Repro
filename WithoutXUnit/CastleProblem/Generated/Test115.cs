using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test115
    {
        private readonly Mock<IClass115> aClass;

        public Test115()
        {
            this.aClass = new Mock<IClass115>();
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
