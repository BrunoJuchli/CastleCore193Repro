using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test391
    {
        private readonly Mock<IClass391> aClass;

        public Test391()
        {
            this.aClass = new Mock<IClass391>();
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
