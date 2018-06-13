using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test560
    {
        private readonly Mock<IClass560> aClass;

        public Test560()
        {
            this.aClass = new Mock<IClass560>();
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
