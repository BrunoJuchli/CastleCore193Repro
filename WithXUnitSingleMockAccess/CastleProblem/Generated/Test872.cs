using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test872
    {
        private readonly Mock<IClass872> aClass;

        public Test872()
        {
            this.aClass = new Mock<IClass872>();
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
