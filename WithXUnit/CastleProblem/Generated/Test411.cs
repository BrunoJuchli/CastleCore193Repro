using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test411
    {
        private readonly Mock<IClass411> aClass;

        public Test411()
        {
            this.aClass = new Mock<IClass411>();
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
