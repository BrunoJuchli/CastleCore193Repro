using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test789
    {
        private readonly Mock<IClass789> aClass;

        public Test789()
        {
            this.aClass = new Mock<IClass789>();
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
