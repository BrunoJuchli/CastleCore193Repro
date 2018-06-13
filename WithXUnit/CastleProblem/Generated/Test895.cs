using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test895
    {
        private readonly Mock<IClass895> aClass;

        public Test895()
        {
            this.aClass = new Mock<IClass895>();
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
