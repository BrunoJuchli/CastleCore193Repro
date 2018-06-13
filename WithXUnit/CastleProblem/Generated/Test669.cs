using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test669
    {
        private readonly Mock<IClass669> aClass;

        public Test669()
        {
            this.aClass = new Mock<IClass669>();
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
