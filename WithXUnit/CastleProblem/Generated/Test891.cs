using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test891
    {
        private readonly Mock<IClass891> aClass;

        public Test891()
        {
            this.aClass = new Mock<IClass891>();
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
