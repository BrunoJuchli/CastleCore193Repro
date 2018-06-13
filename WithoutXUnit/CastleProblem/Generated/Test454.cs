using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test454
    {
        private readonly Mock<IClass454> aClass;

        public Test454()
        {
            this.aClass = new Mock<IClass454>();
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
