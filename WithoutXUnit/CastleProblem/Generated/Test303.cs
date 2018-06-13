using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test303
    {
        private readonly Mock<IClass303> aClass;

        public Test303()
        {
            this.aClass = new Mock<IClass303>();
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
