using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test796
    {
        private readonly Mock<IClass796> aClass;

        public Test796()
        {
            this.aClass = new Mock<IClass796>();
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
