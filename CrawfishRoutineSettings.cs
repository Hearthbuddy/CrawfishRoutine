using Triton.Bot.Settings;

namespace CrawfishRoutine
{
    public class CrawfishRoutineSettings : JsonSettings
    {
        private static CrawfishRoutineSettings? _instance;

        public static CrawfishRoutineSettings Instance =>
            _instance ??= new CrawfishRoutineSettings();

        public bool EnableReplayRecording { get; set; } = true;
        public string ReplayDirectory { get; set; } = "Replays";
        public bool EnableStrategy { get; set; } = true;

        public CrawfishRoutineSettings() : base("CrawfishRoutine") { }
    }
}
