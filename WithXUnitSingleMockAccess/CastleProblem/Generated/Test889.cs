using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test889
    {
        private readonly Mock<IClass889> aClass;

        public Test889()
        {
            this.aClass = new Mock<IClass889>();
        }

        [Theory]
        [InlineData(true)]
        public void DoSomething(bool value)
        {
            this.aClass.Setup(x => x.DoSomething()).Returns(value);

            Assert.Equal(this.aClass.Object.DoSomething(), value);
        }
    }
}
