using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test679
    {
        private readonly Mock<IClass679> aClass;

        public Test679()
        {
            this.aClass = new Mock<IClass679>();
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
