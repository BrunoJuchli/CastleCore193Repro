using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test71
    {
        private readonly Mock<IClass71> aClass;

        public Test71()
        {
            this.aClass = new Mock<IClass71>();
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
