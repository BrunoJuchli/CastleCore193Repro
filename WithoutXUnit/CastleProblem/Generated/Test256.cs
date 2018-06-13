using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test256
    {
        private readonly Mock<IClass256> aClass;

        public Test256()
        {
            this.aClass = new Mock<IClass256>();
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
