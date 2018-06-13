using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test478
    {
        private readonly Mock<IClass478> aClass;

        public Test478()
        {
            this.aClass = new Mock<IClass478>();
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
