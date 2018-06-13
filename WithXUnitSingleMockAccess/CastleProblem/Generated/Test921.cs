using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test921
    {
        private readonly Mock<IClass921> aClass;

        public Test921()
        {
            this.aClass = new Mock<IClass921>();
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
