using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test302
    {
        private readonly Mock<IClass302> aClass;

        public Test302()
        {
            this.aClass = new Mock<IClass302>();
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
