using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test677
    {
        private readonly Mock<IClass677> aClass;

        public Test677()
        {
            this.aClass = new Mock<IClass677>();
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
