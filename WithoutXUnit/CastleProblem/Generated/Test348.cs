using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test348
    {
        private readonly Mock<IClass348> aClass;

        public Test348()
        {
            this.aClass = new Mock<IClass348>();
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
