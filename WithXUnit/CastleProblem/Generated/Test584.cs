using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test584
    {
        private readonly Mock<IClass584> aClass;

        public Test584()
        {
            this.aClass = new Mock<IClass584>();
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
