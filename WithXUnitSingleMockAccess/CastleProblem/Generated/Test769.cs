using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test769
    {
        private readonly Mock<IClass769> aClass;

        public Test769()
        {
            this.aClass = new Mock<IClass769>();
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
