using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test211
    {
        private readonly Mock<IClass211> aClass;

        public Test211()
        {
            this.aClass = new Mock<IClass211>();
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
