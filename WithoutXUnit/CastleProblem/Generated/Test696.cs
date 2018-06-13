using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test696
    {
        private readonly Mock<IClass696> aClass;

        public Test696()
        {
            this.aClass = new Mock<IClass696>();
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
