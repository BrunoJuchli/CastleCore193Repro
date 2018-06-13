using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test855
    {
        private readonly Mock<IClass855> aClass;

        public Test855()
        {
            this.aClass = new Mock<IClass855>();
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
