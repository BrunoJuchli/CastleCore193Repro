using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test333
    {
        private readonly Mock<IClass333> aClass;

        public Test333()
        {
            this.aClass = new Mock<IClass333>();
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
