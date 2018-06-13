using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test257
    {
        private readonly Mock<IClass257> aClass;

        public Test257()
        {
            this.aClass = new Mock<IClass257>();
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
