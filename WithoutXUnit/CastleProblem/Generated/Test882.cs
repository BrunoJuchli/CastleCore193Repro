using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test882
    {
        private readonly Mock<IClass882> aClass;

        public Test882()
        {
            this.aClass = new Mock<IClass882>();
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
