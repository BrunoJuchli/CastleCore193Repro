using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test891
    {
        private readonly Mock<IClass891> aClass;

        public Test891()
        {
            this.aClass = new Mock<IClass891>();
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
