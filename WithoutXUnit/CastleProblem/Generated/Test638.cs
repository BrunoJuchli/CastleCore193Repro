using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test638
    {
        private readonly Mock<IClass638> aClass;

        public Test638()
        {
            this.aClass = new Mock<IClass638>();
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
