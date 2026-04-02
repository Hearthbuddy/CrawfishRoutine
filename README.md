# CrawfishRoutine

龙虾版天梯对战策略 - 参考 Silverfish 实现的天梯对战 AI

## 项目结构

```
CrawfishRoutine/
├── CrawfishRoutine.csproj        # 主项目文件（根目录）
├── CrawfishAI/                   # 核心AI实现
│   ├── Strategy.cs               # 策略核心
│   └── DecisionEngine.cs         # 决策引擎
├── ReplayRecorder/               # 回放录制
│   ├── PowerLogReader.cs         # Power.log 读取器
│   └── ReplayMaker.cs            # 回放文件生成器
├── lib/                          # 第三方 DLL 引用
│   └── HearthWatcher.dll         # HDT 的日志监听组件
├── Tests/                        # 单元测试
│   └── CrawfishRoutine.Tests.csproj
├── CrawfishRoutine.cs            # 主程序对接（IPlugin 实现）
├── CrawfishRoutineSettings.cs    # 插件设置
└── SettingsGui.xaml              # 设置界面
```

## 功能模块

### CrawfishAI - 核心AI实现
- 策略系统（参考 Silverfish）
- 决策引擎
- 卡牌评估

### ReplayRecorder - 回放录制
- Power.log 实时读取（使用 HearthWatcher）
- 游戏状态跟踪
- 回放文件生成（HDT 兼容格式）

### lib - 第三方 DLL
- **HearthWatcher.dll** - HDT 的日志监听组件（从 HDT release 获取）

## 开发环境设置

1. 获取 HearthWatcher.dll
   - 从 HDT release 中提取 HearthWatcher.dll
   - 放置到 `lib/` 目录

2. 编译项目
   - 使用 Visual Studio 或 Rider 打开 `CrawfishRoutine.csproj`
   - 确保引用路径正确指向 `../Hearthbuddy/` 目录

3. 运行测试
   - 使用 NUnit 运行测试

## 开发状态

🚧 开发中

### TODO
- [ ] 获取并集成 HearthWatcher.dll
- [ ] 实现 Power.log 收集
- [ ] 实现回放文件保存
- [ ] 实现策略决策核心
- [ ] 完善单元测试

## 技术栈

- .NET Framework 4.7.2
- NUnit 3.13.3
- WPF
- log4net
- HearthWatcher (HDT 组件)

## 致谢

- Silverfish - 策略参考
- Hearthstone Deck Tracker - 回放格式和 HearthWatcher 组件

## 许可证

MIT License
