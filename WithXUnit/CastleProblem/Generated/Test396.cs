using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test396
    {
        private readonly Mock<IClass396> aClass;

        public Test396()
        {
            this.aClass = new Mock<IClass396>();
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
