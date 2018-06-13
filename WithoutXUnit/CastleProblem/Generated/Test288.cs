using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test288
    {
        private readonly Mock<IClass288> aClass;

        public Test288()
        {
            this.aClass = new Mock<IClass288>();
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
