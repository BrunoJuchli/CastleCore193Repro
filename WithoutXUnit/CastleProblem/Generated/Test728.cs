using System;
using System.Diagnostics;
using Moq;

namespace CastleProblem
{
    public class Test728
    {
        private readonly Mock<IClass728> aClass;

        public Test728()
        {
            this.aClass = new Mock<IClass728>();
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
