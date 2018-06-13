using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test952
    {
        private readonly Mock<IClass952> aClass;

        public Test952()
        {
            this.aClass = new Mock<IClass952>();
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
