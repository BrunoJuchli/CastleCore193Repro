using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test543
    {
        private readonly Mock<IClass543> aClass;

        public Test543()
        {
            this.aClass = new Mock<IClass543>();
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
