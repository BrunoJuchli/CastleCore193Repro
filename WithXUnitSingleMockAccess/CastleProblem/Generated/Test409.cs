using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test409
    {
        private readonly Mock<IClass409> aClass;

        public Test409()
        {
            this.aClass = new Mock<IClass409>();
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
