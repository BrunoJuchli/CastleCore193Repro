using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test589
    {
        private readonly Mock<IClass589> aClass;

        public Test589()
        {
            this.aClass = new Mock<IClass589>();
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
