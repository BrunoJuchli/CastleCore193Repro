using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test564
    {
        private readonly Mock<IClass564> aClass;

        public Test564()
        {
            this.aClass = new Mock<IClass564>();
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
