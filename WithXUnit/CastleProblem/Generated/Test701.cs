using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test701
    {
        private readonly Mock<IClass701> aClass;

        public Test701()
        {
            this.aClass = new Mock<IClass701>();
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
