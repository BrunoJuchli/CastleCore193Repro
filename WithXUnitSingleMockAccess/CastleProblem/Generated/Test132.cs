using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test132
    {
        private readonly Mock<IClass132> aClass;

        public Test132()
        {
            this.aClass = new Mock<IClass132>();
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
