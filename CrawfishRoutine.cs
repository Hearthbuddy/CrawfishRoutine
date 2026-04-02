using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using log4net;
using Triton.Bot;
using Triton.Bot.Settings;
using Triton.Common;
using Triton.Game;
using Logger = Triton.Common.LogUtilities.Logger;

namespace CrawfishRoutine
{
    /// <summary>
    /// 龙虾版天梯对战策略 - 主程序对接
    /// </summary>
    public class CrawfishRoutine : IPlugin
    {
        private static readonly ILog Log = Logger.GetLoggerInstanceForType();
        private UserControl? _control;
        private bool _enabled;

        public string Name => "龙虾版天梯策略";
        public string Description => "参考 Silverfish 实现的天梯对战 AI";
        public string Author => "龙虾版天梯对战机器人";
        public string Version => "1.0.0.0";

        public JsonSettings Settings => CrawfishRoutineSettings.Instance;
        
        /// <summary>插件是否启用</summary>
        public bool IsEnabled => _enabled;

        public void Initialize()
        {
            Log.Info("[龙虾版天梯策略] 初始化");
            if (!MainSettings.Instance.EnabledPlugins.Contains(this.Name))
                MainSettings.Instance.EnabledPlugins.Add(this.Name);
        }

        public void Start()
        {
            Log.Info("[龙虾版天梯策略] 启动");
            GameEventManager.GameOver += OnGameOver;
            GameEventManager.NewGame += OnNewGame;
        }

        public void Tick()
        {
            // TODO: 实现策略逻辑
        }

        public void Stop()
        {
            Log.Info("[龙虾版天梯策略] 停止");
            GameEventManager.GameOver -= OnGameOver;
            GameEventManager.NewGame -= OnNewGame;
        }

        public void Deinitialize()
        {
            Log.Info("[龙虾版天梯策略] 反初始化");
        }

        public void Enable()
        {
            Log.Info("[龙虾版天梯策略] 启用");
            _enabled = true;
        }

        public void Disable()
        {
            Log.Info("[龙虾版天梯策略] 禁用");
            _enabled = false;
        }

        public UserControl Control
        {
            get
            {
                if (_control != null)
                    return _control;

                try
                {
                    var xamlPath = Path.Combine("Plugins", "CrawfishRoutine", "SettingsGui.xaml");
                    if (File.Exists(xamlPath))
                    {
                        using (var fs = new FileStream(xamlPath, FileMode.Open))
                        {
                            _control = (UserControl)System.Windows.Markup.XamlReader.Load(fs);
                        }
                    }
                    else
                    {
                        _control = CreateSimpleSettingsControl();
                    }
                }
                catch (Exception ex)
                {
                    Log.Error($"[龙虾版天梯策略] 加载设置界面失败: {ex.Message}");
                    _control = CreateSimpleSettingsControl();
                }

                return _control;
            }
        }

        private UserControl CreateSimpleSettingsControl()
        {
            var panel = new StackPanel { Margin = new Thickness(10) };
            var title = new TextBlock
            {
                Text = "龙虾版天梯策略设置",
                FontWeight = FontWeights.Bold,
                FontSize = 14
            };
            panel.Children.Add(title);
            return new UserControl { Content = panel };
        }

        private void OnNewGame(object? sender, NewGameEventArgs e)
        {
            Log.Info("[龙虾版天梯策略] 游戏开始");
            // TODO: 初始化策略和日志记录
        }

        private void OnGameOver(object? sender, GameOverEventArgs e)
        {
            Log.Info("[龙虾版天梯策略] 游戏结束");
            // TODO: 保存回放文件
        }
    }
}
