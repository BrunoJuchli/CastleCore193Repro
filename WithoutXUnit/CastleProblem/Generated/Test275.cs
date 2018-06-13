using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test275
    {
        private readonly Mock<IClass275> aClass;

        public Test275()
        {
            this.aClass = new Mock<IClass275>();
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
