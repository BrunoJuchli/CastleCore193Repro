using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test895
    {
        private readonly Mock<IClass895> aClass;

        public Test895()
        {
            this.aClass = new Mock<IClass895>();
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
