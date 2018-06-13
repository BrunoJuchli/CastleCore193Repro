using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test823
    {
        private readonly Mock<IClass823> aClass;

        public Test823()
        {
            this.aClass = new Mock<IClass823>();
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
