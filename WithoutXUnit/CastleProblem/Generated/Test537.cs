using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test537
    {
        private readonly Mock<IClass537> aClass;

        public Test537()
        {
            this.aClass = new Mock<IClass537>();
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
