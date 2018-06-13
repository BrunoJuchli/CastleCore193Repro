using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test869
    {
        private readonly Mock<IClass869> aClass;

        public Test869()
        {
            this.aClass = new Mock<IClass869>();
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
