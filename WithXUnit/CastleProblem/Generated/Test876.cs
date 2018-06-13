using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test876
    {
        private readonly Mock<IClass876> aClass;

        public Test876()
        {
            this.aClass = new Mock<IClass876>();
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
