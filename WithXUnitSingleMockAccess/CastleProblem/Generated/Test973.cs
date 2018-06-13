using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test973
    {
        private readonly Mock<IClass973> aClass;

        public Test973()
        {
            this.aClass = new Mock<IClass973>();
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
