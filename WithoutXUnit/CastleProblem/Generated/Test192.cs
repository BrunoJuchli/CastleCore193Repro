using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test192
    {
        private readonly Mock<IClass192> aClass;

        public Test192()
        {
            this.aClass = new Mock<IClass192>();
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
