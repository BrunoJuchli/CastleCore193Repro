using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test700
    {
        private readonly Mock<IClass700> aClass;

        public Test700()
        {
            this.aClass = new Mock<IClass700>();
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
