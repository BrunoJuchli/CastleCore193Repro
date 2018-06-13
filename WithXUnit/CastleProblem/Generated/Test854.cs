using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test854
    {
        private readonly Mock<IClass854> aClass;

        public Test854()
        {
            this.aClass = new Mock<IClass854>();
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
