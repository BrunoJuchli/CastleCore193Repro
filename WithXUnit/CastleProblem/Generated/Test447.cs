using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test447
    {
        private readonly Mock<IClass447> aClass;

        public Test447()
        {
            this.aClass = new Mock<IClass447>();
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
