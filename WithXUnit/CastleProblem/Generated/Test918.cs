using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test918
    {
        private readonly Mock<IClass918> aClass;

        public Test918()
        {
            this.aClass = new Mock<IClass918>();
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
