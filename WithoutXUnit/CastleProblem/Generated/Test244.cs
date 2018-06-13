using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test244
    {
        private readonly Mock<IClass244> aClass;

        public Test244()
        {
            this.aClass = new Mock<IClass244>();
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
