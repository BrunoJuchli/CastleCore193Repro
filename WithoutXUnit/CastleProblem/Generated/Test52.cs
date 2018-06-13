using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test52
    {
        private readonly Mock<IClass52> aClass;

        public Test52()
        {
            this.aClass = new Mock<IClass52>();
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
