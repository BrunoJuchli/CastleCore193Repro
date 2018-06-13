using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test95
    {
        private readonly Mock<IClass95> aClass;

        public Test95()
        {
            this.aClass = new Mock<IClass95>();
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
