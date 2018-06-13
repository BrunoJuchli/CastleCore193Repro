using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test352
    {
        private readonly Mock<IClass352> aClass;

        public Test352()
        {
            this.aClass = new Mock<IClass352>();
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
