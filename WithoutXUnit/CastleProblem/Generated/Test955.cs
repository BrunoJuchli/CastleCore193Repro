using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test955
    {
        private readonly Mock<IClass955> aClass;

        public Test955()
        {
            this.aClass = new Mock<IClass955>();
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
