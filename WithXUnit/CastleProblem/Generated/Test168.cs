using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test168
    {
        private readonly Mock<IClass168> aClass;

        public Test168()
        {
            this.aClass = new Mock<IClass168>();
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
