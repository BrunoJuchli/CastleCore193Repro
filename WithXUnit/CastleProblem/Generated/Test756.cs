using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test756
    {
        private readonly Mock<IClass756> aClass;

        public Test756()
        {
            this.aClass = new Mock<IClass756>();
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
