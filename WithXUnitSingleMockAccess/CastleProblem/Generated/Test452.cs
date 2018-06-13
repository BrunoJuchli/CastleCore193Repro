using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test452
    {
        private readonly Mock<IClass452> aClass;

        public Test452()
        {
            this.aClass = new Mock<IClass452>();
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
