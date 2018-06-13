using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test413
    {
        private readonly Mock<IClass413> aClass;

        public Test413()
        {
            this.aClass = new Mock<IClass413>();
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
