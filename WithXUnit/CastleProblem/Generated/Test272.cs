using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test272
    {
        private readonly Mock<IClass272> aClass;

        public Test272()
        {
            this.aClass = new Mock<IClass272>();
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
