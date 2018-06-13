using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test462
    {
        private readonly Mock<IClass462> aClass;

        public Test462()
        {
            this.aClass = new Mock<IClass462>();
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
