using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test958
    {
        private readonly Mock<IClass958> aClass;

        public Test958()
        {
            this.aClass = new Mock<IClass958>();
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
