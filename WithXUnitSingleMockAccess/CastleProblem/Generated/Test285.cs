using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test285
    {
        private readonly Mock<IClass285> aClass;

        public Test285()
        {
            this.aClass = new Mock<IClass285>();
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
