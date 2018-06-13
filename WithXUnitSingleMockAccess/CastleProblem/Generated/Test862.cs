using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test862
    {
        private readonly Mock<IClass862> aClass;

        public Test862()
        {
            this.aClass = new Mock<IClass862>();
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
