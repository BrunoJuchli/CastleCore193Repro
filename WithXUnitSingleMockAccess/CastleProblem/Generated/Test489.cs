using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test489
    {
        private readonly Mock<IClass489> aClass;

        public Test489()
        {
            this.aClass = new Mock<IClass489>();
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
