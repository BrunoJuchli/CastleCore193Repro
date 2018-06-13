using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test666
    {
        private readonly Mock<IClass666> aClass;

        public Test666()
        {
            this.aClass = new Mock<IClass666>();
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
