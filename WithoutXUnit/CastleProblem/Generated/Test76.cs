using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test76
    {
        private readonly Mock<IClass76> aClass;

        public Test76()
        {
            this.aClass = new Mock<IClass76>();
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
