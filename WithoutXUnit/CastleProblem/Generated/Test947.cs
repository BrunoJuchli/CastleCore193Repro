using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test947
    {
        private readonly Mock<IClass947> aClass;

        public Test947()
        {
            this.aClass = new Mock<IClass947>();
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
