using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test21
    {
        private readonly Mock<IClass21> aClass;

        public Test21()
        {
            this.aClass = new Mock<IClass21>();
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
