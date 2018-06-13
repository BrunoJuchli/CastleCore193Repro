using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test399
    {
        private readonly Mock<IClass399> aClass;

        public Test399()
        {
            this.aClass = new Mock<IClass399>();
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
