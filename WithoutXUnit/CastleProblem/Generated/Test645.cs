using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test645
    {
        private readonly Mock<IClass645> aClass;

        public Test645()
        {
            this.aClass = new Mock<IClass645>();
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
