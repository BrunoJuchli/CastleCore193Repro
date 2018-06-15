using System;
using System.Diagnostics;
using Moq;

namespace NetCoreRepro.ToDuplicate
{
    public class Test66
    {
        private readonly Mock<IClass66> aClass;

        public Test66()
        {
            this.aClass = new Mock<IClass66>();
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
