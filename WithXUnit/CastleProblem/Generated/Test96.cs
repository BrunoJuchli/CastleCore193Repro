using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test96
    {
        private readonly Mock<IClass96> aClass;

        public Test96()
        {
            this.aClass = new Mock<IClass96>();
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
