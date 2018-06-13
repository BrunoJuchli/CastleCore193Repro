using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test591
    {
        private readonly Mock<IClass591> aClass;

        public Test591()
        {
            this.aClass = new Mock<IClass591>();
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
