using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test601
    {
        private readonly Mock<IClass601> aClass;

        public Test601()
        {
            this.aClass = new Mock<IClass601>();
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
