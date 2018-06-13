using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test806
    {
        private readonly Mock<IClass806> aClass;

        public Test806()
        {
            this.aClass = new Mock<IClass806>();
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
