using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test5
    {
        private readonly Mock<IClass5> aClass;

        public Test5()
        {
            this.aClass = new Mock<IClass5>();
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
