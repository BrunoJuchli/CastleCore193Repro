using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test876
    {
        private readonly Mock<IClass876> aClass;

        public Test876()
        {
            this.aClass = new Mock<IClass876>();
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
