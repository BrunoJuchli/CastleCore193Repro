using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test132
    {
        private readonly Mock<IClass132> aClass;

        public Test132()
        {
            this.aClass = new Mock<IClass132>();
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
