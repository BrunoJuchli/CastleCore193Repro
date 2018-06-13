using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test168
    {
        private readonly Mock<IClass168> aClass;

        public Test168()
        {
            this.aClass = new Mock<IClass168>();
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
