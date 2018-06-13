using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test675
    {
        private readonly Mock<IClass675> aClass;

        public Test675()
        {
            this.aClass = new Mock<IClass675>();
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
