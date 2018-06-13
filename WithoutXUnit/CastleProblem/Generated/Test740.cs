using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test740
    {
        private readonly Mock<IClass740> aClass;

        public Test740()
        {
            this.aClass = new Mock<IClass740>();
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
