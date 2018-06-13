using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test419
    {
        private readonly Mock<IClass419> aClass;

        public Test419()
        {
            this.aClass = new Mock<IClass419>();
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
