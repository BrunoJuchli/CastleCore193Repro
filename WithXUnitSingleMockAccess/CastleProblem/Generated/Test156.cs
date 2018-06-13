using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test156
    {
        private readonly Mock<IClass156> aClass;

        public Test156()
        {
            this.aClass = new Mock<IClass156>();
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
