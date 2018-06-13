using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test825
    {
        private readonly Mock<IClass825> aClass;

        public Test825()
        {
            this.aClass = new Mock<IClass825>();
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
