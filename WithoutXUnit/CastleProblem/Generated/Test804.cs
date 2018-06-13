using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test804
    {
        private readonly Mock<IClass804> aClass;

        public Test804()
        {
            this.aClass = new Mock<IClass804>();
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
