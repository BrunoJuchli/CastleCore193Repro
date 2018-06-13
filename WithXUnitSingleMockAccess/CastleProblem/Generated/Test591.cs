using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test591
    {
        private readonly Mock<IClass591> aClass;

        public Test591()
        {
            this.aClass = new Mock<IClass591>();
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
