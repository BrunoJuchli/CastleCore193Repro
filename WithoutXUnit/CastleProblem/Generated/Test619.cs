using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test619
    {
        private readonly Mock<IClass619> aClass;

        public Test619()
        {
            this.aClass = new Mock<IClass619>();
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
