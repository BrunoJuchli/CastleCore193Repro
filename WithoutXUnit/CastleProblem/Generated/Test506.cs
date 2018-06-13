using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test506
    {
        private readonly Mock<IClass506> aClass;

        public Test506()
        {
            this.aClass = new Mock<IClass506>();
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
