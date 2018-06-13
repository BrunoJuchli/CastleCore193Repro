using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test217
    {
        private readonly Mock<IClass217> aClass;

        public Test217()
        {
            this.aClass = new Mock<IClass217>();
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
