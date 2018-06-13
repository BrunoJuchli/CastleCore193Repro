using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test618
    {
        private readonly Mock<IClass618> aClass;

        public Test618()
        {
            this.aClass = new Mock<IClass618>();
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
