using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test184
    {
        private readonly Mock<IClass184> aClass;

        public Test184()
        {
            this.aClass = new Mock<IClass184>();
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
