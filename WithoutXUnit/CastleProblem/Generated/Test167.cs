using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test167
    {
        private readonly Mock<IClass167> aClass;

        public Test167()
        {
            this.aClass = new Mock<IClass167>();
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
