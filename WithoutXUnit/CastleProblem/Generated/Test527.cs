using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test527
    {
        private readonly Mock<IClass527> aClass;

        public Test527()
        {
            this.aClass = new Mock<IClass527>();
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
