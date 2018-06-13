using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test399
    {
        private readonly Mock<IClass399> aClass;

        public Test399()
        {
            this.aClass = new Mock<IClass399>();
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
