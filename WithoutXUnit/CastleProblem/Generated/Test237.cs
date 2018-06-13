using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test237
    {
        private readonly Mock<IClass237> aClass;

        public Test237()
        {
            this.aClass = new Mock<IClass237>();
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
