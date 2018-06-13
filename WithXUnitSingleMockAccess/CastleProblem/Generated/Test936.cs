using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test936
    {
        private readonly Mock<IClass936> aClass;

        public Test936()
        {
            this.aClass = new Mock<IClass936>();
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
