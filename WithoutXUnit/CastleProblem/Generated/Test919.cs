using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test919
    {
        private readonly Mock<IClass919> aClass;

        public Test919()
        {
            this.aClass = new Mock<IClass919>();
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
