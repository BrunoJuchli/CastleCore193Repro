using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test358
    {
        private readonly Mock<IClass358> aClass;

        public Test358()
        {
            this.aClass = new Mock<IClass358>();
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
