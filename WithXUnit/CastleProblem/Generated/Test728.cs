using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test728
    {
        private readonly Mock<IClass728> aClass;

        public Test728()
        {
            this.aClass = new Mock<IClass728>();
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
