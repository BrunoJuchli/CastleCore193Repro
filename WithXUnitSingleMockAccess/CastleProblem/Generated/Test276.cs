using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test276
    {
        private readonly Mock<IClass276> aClass;

        public Test276()
        {
            this.aClass = new Mock<IClass276>();
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
