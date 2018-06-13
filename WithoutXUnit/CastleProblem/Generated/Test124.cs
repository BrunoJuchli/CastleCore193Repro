using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test124
    {
        private readonly Mock<IClass124> aClass;

        public Test124()
        {
            this.aClass = new Mock<IClass124>();
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
