using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test2
    {
        private readonly Mock<IClass2> aClass;

        public Test2()
        {
            this.aClass = new Mock<IClass2>();
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
