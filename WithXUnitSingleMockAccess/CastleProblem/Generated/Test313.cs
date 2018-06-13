using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test313
    {
        private readonly Mock<IClass313> aClass;

        public Test313()
        {
            this.aClass = new Mock<IClass313>();
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
