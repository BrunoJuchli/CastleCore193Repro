using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test568
    {
        private readonly Mock<IClass568> aClass;

        public Test568()
        {
            this.aClass = new Mock<IClass568>();
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
