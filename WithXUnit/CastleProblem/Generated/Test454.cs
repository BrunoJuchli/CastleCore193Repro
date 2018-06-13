using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test454
    {
        private readonly Mock<IClass454> aClass;

        public Test454()
        {
            this.aClass = new Mock<IClass454>();
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
