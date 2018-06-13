using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test425
    {
        private readonly Mock<IClass425> aClass;

        public Test425()
        {
            this.aClass = new Mock<IClass425>();
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
