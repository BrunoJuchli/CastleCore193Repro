using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test470
    {
        private readonly Mock<IClass470> aClass;

        public Test470()
        {
            this.aClass = new Mock<IClass470>();
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
