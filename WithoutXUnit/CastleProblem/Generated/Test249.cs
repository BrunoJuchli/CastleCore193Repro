using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test249
    {
        private readonly Mock<IClass249> aClass;

        public Test249()
        {
            this.aClass = new Mock<IClass249>();
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
