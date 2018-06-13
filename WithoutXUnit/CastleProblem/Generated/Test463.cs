using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test463
    {
        private readonly Mock<IClass463> aClass;

        public Test463()
        {
            this.aClass = new Mock<IClass463>();
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
