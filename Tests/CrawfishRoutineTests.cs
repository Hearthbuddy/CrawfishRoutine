using NUnit.Framework;

namespace CrawfishRoutine.Tests
{
    [TestFixture]
    public class CrawfishRoutineTests
    {
        [Test]
        public void Test_Plugin_Name()
        {
            var plugin = new CrawfishRoutine();
            Assert.AreEqual("龙虾版天梯策略", plugin.Name);
        }

        [Test]
        public void Test_Plugin_Description()
        {
            var plugin = new CrawfishRoutine();
            Assert.AreEqual("参考 Silverfish 实现的天梯对战 AI", plugin.Description);
        }

        [Test]
        public void Test_Plugin_Settings()
        {
            var settings = CrawfishRoutineSettings.Instance;
            Assert.IsTrue(settings.EnableReplayRecording);
            Assert.IsTrue(settings.EnableStrategy);
            Assert.AreEqual("Replays", settings.ReplayDirectory);
        }
    }
}
