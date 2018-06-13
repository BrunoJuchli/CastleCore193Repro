using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test701
    {
        private readonly Mock<IClass701> aClass;

        public Test701()
        {
            this.aClass = new Mock<IClass701>();
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
