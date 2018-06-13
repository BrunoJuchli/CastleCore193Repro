using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test560
    {
        private readonly Mock<IClass560> aClass;

        public Test560()
        {
            this.aClass = new Mock<IClass560>();
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
