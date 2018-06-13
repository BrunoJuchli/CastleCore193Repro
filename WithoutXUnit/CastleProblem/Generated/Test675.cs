using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test675
    {
        private readonly Mock<IClass675> aClass;

        public Test675()
        {
            this.aClass = new Mock<IClass675>();
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
