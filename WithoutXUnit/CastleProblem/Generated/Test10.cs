using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test10
    {
        private readonly Mock<IClass10> aClass;

        public Test10()
        {
            this.aClass = new Mock<IClass10>();
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
