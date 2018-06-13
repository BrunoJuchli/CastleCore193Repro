using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test275
    {
        private readonly Mock<IClass275> aClass;

        public Test275()
        {
            this.aClass = new Mock<IClass275>();
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
