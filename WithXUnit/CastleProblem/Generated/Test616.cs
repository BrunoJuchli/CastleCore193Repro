using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test616
    {
        private readonly Mock<IClass616> aClass;

        public Test616()
        {
            this.aClass = new Mock<IClass616>();
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
