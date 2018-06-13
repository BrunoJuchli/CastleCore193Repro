using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test722
    {
        private readonly Mock<IClass722> aClass;

        public Test722()
        {
            this.aClass = new Mock<IClass722>();
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
