using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test161
    {
        private readonly Mock<IClass161> aClass;

        public Test161()
        {
            this.aClass = new Mock<IClass161>();
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
