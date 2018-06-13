using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test203
    {
        private readonly Mock<IClass203> aClass;

        public Test203()
        {
            this.aClass = new Mock<IClass203>();
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
