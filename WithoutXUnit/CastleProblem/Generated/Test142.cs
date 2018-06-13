using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test142
    {
        private readonly Mock<IClass142> aClass;

        public Test142()
        {
            this.aClass = new Mock<IClass142>();
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
