# lib 目录说明

此目录用于存放第三方 DLL 引用。

## 需要的 DLL

### HearthWatcher.dll

**来源**: Hearthstone Deck Tracker (HDT) release

**用途**: 日志监听组件，用于实时读取炉石的 Power.log 文件

**获取方法**:
1. 从 HDT GitHub release 下载最新版本
2. 解压后找到 HearthWatcher.dll
3. 复制到此目录

**GitHub 地址**: https://github.com/HearthSim/Hearthstone-Deck-Tracker/releases

## 注意事项

- 此目录中的 DLL 不应该提交到 Git（已在 .gitignore 中排除）
- 首次开发前需要手动获取并放置这些 DLL
- DLL 版本应与项目兼容
