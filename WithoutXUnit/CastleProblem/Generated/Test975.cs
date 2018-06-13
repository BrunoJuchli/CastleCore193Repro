using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test975
    {
        private readonly Mock<IClass975> aClass;

        public Test975()
        {
            this.aClass = new Mock<IClass975>();
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
