using System;
using System.Diagnostics;
using Moq;

namespace NetCoreRepro.ToDuplicate
{
    public class Test817
    {
        private readonly Mock<IClass817> aClass;

        public Test817()
        {
            this.aClass = new Mock<IClass817>();
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