using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test306
    {
        private readonly Mock<IClass306> aClass;

        public Test306()
        {
            this.aClass = new Mock<IClass306>();
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
