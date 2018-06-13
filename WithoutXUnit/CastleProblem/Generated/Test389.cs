using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test389
    {
        private readonly Mock<IClass389> aClass;

        public Test389()
        {
            this.aClass = new Mock<IClass389>();
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
