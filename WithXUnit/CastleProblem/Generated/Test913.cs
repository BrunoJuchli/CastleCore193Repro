using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test913
    {
        private readonly Mock<IClass913> aClass;

        public Test913()
        {
            this.aClass = new Mock<IClass913>();
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
