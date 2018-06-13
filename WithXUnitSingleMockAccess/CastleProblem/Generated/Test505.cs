using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test505
    {
        private readonly Mock<IClass505> aClass;

        public Test505()
        {
            this.aClass = new Mock<IClass505>();
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
