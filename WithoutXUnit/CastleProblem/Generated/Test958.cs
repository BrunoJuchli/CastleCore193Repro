using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test958
    {
        private readonly Mock<IClass958> aClass;

        public Test958()
        {
            this.aClass = new Mock<IClass958>();
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
