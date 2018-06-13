using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test875
    {
        private readonly Mock<IClass875> aClass;

        public Test875()
        {
            this.aClass = new Mock<IClass875>();
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
