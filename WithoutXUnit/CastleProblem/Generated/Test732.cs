using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test732
    {
        private readonly Mock<IClass732> aClass;

        public Test732()
        {
            this.aClass = new Mock<IClass732>();
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
