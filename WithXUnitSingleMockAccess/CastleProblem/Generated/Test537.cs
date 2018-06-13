using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test537
    {
        private readonly Mock<IClass537> aClass;

        public Test537()
        {
            this.aClass = new Mock<IClass537>();
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
