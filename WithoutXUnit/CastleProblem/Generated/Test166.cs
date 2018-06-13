using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test166
    {
        private readonly Mock<IClass166> aClass;

        public Test166()
        {
            this.aClass = new Mock<IClass166>();
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
