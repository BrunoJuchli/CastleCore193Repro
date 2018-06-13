using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test890
    {
        private readonly Mock<IClass890> aClass;

        public Test890()
        {
            this.aClass = new Mock<IClass890>();
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
