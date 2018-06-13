using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test959
    {
        private readonly Mock<IClass959> aClass;

        public Test959()
        {
            this.aClass = new Mock<IClass959>();
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
