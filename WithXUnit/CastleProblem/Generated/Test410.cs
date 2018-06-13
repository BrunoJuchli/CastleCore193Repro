using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test410
    {
        private readonly Mock<IClass410> aClass;

        public Test410()
        {
            this.aClass = new Mock<IClass410>();
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
