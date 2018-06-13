using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test346
    {
        private readonly Mock<IClass346> aClass;

        public Test346()
        {
            this.aClass = new Mock<IClass346>();
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
