using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test466
    {
        private readonly Mock<IClass466> aClass;

        public Test466()
        {
            this.aClass = new Mock<IClass466>();
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
