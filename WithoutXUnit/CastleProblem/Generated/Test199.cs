using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test199
    {
        private readonly Mock<IClass199> aClass;

        public Test199()
        {
            this.aClass = new Mock<IClass199>();
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
