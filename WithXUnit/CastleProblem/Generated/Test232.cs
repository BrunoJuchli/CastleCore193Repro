using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test232
    {
        private readonly Mock<IClass232> aClass;

        public Test232()
        {
            this.aClass = new Mock<IClass232>();
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
