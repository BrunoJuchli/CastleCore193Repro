using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test229
    {
        private readonly Mock<IClass229> aClass;

        public Test229()
        {
            this.aClass = new Mock<IClass229>();
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
