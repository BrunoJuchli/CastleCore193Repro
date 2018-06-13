using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test807
    {
        private readonly Mock<IClass807> aClass;

        public Test807()
        {
            this.aClass = new Mock<IClass807>();
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
