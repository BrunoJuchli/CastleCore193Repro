using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test496
    {
        private readonly Mock<IClass496> aClass;

        public Test496()
        {
            this.aClass = new Mock<IClass496>();
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
