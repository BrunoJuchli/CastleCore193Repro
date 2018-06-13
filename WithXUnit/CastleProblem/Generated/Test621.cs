using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test621
    {
        private readonly Mock<IClass621> aClass;

        public Test621()
        {
            this.aClass = new Mock<IClass621>();
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void DoSomething(bool value)
        {
            this.aClass.Setup(x => x.DoSomething()).Returns(value);

            Assert.Equal(this.aClass.Object.DoSomething(), value);
        }
    }
}
