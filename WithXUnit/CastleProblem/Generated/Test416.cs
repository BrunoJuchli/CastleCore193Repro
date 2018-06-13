using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test416
    {
        private readonly Mock<IClass416> aClass;

        public Test416()
        {
            this.aClass = new Mock<IClass416>();
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
