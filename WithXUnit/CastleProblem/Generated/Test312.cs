using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test312
    {
        private readonly Mock<IClass312> aClass;

        public Test312()
        {
            this.aClass = new Mock<IClass312>();
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
