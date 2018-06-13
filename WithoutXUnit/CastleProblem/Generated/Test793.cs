using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test793
    {
        private readonly Mock<IClass793> aClass;

        public Test793()
        {
            this.aClass = new Mock<IClass793>();
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
