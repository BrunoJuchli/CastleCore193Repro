using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test744
    {
        private readonly Mock<IClass744> aClass;

        public Test744()
        {
            this.aClass = new Mock<IClass744>();
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
