using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test667
    {
        private readonly Mock<IClass667> aClass;

        public Test667()
        {
            this.aClass = new Mock<IClass667>();
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
