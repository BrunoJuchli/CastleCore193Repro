using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test730
    {
        private readonly Mock<IClass730> aClass;

        public Test730()
        {
            this.aClass = new Mock<IClass730>();
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
