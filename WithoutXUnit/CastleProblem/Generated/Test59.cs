using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test59
    {
        private readonly Mock<IClass59> aClass;

        public Test59()
        {
            this.aClass = new Mock<IClass59>();
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
