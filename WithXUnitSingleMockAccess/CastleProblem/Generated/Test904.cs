using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test904
    {
        private readonly Mock<IClass904> aClass;

        public Test904()
        {
            this.aClass = new Mock<IClass904>();
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
