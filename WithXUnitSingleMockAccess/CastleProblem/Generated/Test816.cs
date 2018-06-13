using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test816
    {
        private readonly Mock<IClass816> aClass;

        public Test816()
        {
            this.aClass = new Mock<IClass816>();
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
