using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test886
    {
        private readonly Mock<IClass886> aClass;

        public Test886()
        {
            this.aClass = new Mock<IClass886>();
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
