using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test472
    {
        private readonly Mock<IClass472> aClass;

        public Test472()
        {
            this.aClass = new Mock<IClass472>();
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
