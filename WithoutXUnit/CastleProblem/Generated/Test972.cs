using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test972
    {
        private readonly Mock<IClass972> aClass;

        public Test972()
        {
            this.aClass = new Mock<IClass972>();
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
