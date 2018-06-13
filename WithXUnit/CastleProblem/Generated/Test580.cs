using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test580
    {
        private readonly Mock<IClass580> aClass;

        public Test580()
        {
            this.aClass = new Mock<IClass580>();
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
