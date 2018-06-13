using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test740
    {
        private readonly Mock<IClass740> aClass;

        public Test740()
        {
            this.aClass = new Mock<IClass740>();
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
