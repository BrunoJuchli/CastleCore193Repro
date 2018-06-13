using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test227
    {
        private readonly Mock<IClass227> aClass;

        public Test227()
        {
            this.aClass = new Mock<IClass227>();
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
