using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test823
    {
        private readonly Mock<IClass823> aClass;

        public Test823()
        {
            this.aClass = new Mock<IClass823>();
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
