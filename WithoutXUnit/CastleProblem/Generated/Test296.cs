using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test296
    {
        private readonly Mock<IClass296> aClass;

        public Test296()
        {
            this.aClass = new Mock<IClass296>();
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
