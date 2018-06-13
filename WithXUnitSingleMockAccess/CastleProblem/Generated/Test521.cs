using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test521
    {
        private readonly Mock<IClass521> aClass;

        public Test521()
        {
            this.aClass = new Mock<IClass521>();
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
