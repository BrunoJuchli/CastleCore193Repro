using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test530
    {
        private readonly Mock<IClass530> aClass;

        public Test530()
        {
            this.aClass = new Mock<IClass530>();
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
