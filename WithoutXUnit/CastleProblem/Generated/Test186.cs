using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test186
    {
        private readonly Mock<IClass186> aClass;

        public Test186()
        {
            this.aClass = new Mock<IClass186>();
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
