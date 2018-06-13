using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test130
    {
        private readonly Mock<IClass130> aClass;

        public Test130()
        {
            this.aClass = new Mock<IClass130>();
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
