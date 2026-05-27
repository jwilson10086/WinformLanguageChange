# WinForm Language Change

> WinForms 运行时多语言切换示例 —— 基于 XML 语言文件的中英文界面国际化方案

[![Platform](https://img.shields.io/badge/Platform-Windows-blue)](https://github.com)
[![Framework](https://img.shields.io/badge/.NET_Framework-4.7.2-purple)](https://dotnet.microsoft.com/)
[![Language](https://img.shields.io/badge/Language-C%23-green)](https://docs.microsoft.com/en-us/dotnet/csharp/)

---

## 项目简介

本项目演示了在 WinForms 应用中实现**运行时无重启语言切换**的完整方案。不依赖 .NET 内置的 `ResourceManager` 或 `.resx` 文件，而是通过外置 XML 语言文件 + `Localization` 静态类的方式管理多语言文本，架构轻量、易于扩展。

适合需要在工业软件、设备上位机等场景中快速集成中英文切换功能的参考实现。

---

## 功能特性

- **运行时切换**：无需重启程序，点击按钮即可在中文/英文间实时切换
- **XML 驱动**：所有文本存储在外置 `resources/language-zh.xml` / `language-en.xml` 中，翻译人员无需接触代码
- **全组件覆盖**：支持窗体标题、普通控件（Button/Label/TextBox 等）、MenuStrip 菜单、ToolStrip 工具栏、对话框文本的统一更新
- **多窗体支持**：通过 `Localization.AddForm()` 注册各窗体，统一管理
- **容错处理**：语言文件加载失败时自动降级为英文显示，并弹出提示

---

## 技术栈

| 组件 | 版本 | 说明 |
|------|------|------|
| .NET Framework | 4.7.2 | 运行时框架 |
| WinForms | — | 桌面 UI |
| System.Xml | — | XML 语言文件解析 |

---

## 项目结构

```
WinformLanguageChange/
├── WinformLanguageChange/
│   ├── Localization.cs           # 核心本地化类（加载、查询语言文本）
│   ├── Program.cs                # 程序入口 + 窗体语言刷新工具方法
│   ├── MainForm.cs               # 主窗体（演示语言切换按钮）
│   ├── UserLoginForm.cs          # 登录窗体（多语言演示）
│   ├── UserManageForm.cs         # 用户管理窗体
│   ├── ChangePasswordForm.cs     # 修改密码窗体
│   └── resources/
│       ├── language-zh.xml       # 中文语言包
│       └── language-en.xml       # 英文语言包
└── WinformLanguageChange.sln
```

---

## 快速开始

### 环境要求

- Windows 10 / Windows 11
- Visual Studio 2019 / 2022
- .NET Framework 4.7.2

### 编译运行

1. 克隆仓库：
   ```bash
   git clone <repo-url>
   cd WinformLanguageChange
   ```

2. 用 Visual Studio 打开 `WinformLanguageChange.sln`

3. 编译并运行（F5）

4. 点击界面上的语言切换按钮，观察界面中英文实时切换效果

---

## 核心设计

### 语言文件格式（XML）

```xml
<!-- language-zh.xml -->
<Language>
  <Forms>
    <Form name="MainForm">
      <Item key="MainForm">主界面</Item>
      <Item key="buttonGo">切换语言</Item>
    </Form>
    <Form name="UserLoginForm">
      <Item key="UserLoginForm">用户登录</Item>
      <Item key="labelUser">用户名</Item>
    </Form>
  </Forms>
  <Menus>
    <Item key="menuFile">文件</Item>
  </Menus>
  <Dialogs>
    <Item key="1004">操作成功</Item>
    <Item key="0006">提示</Item>
  </Dialogs>
</Language>
```

### 集成到自有项目

**1. 注册窗体**（在 `Program.Main()` 中）：
```csharp
Localization.AddForm("MyForm");
Localization.LoadLanguage("zh");
```

**2. 刷新界面语言**（切换时调用）：
```csharp
// 刷新控件文本
Program.RefreshLanguage(this);
// 刷新菜单
Program.RefreshMenuLanguage(this.menuStrip1);
// 刷新工具栏
Program.RefreshStatusStripLanguage(this.toolStrip1);
```

**3. 在代码中获取文本**：
```csharp
string msg = Localization.Dialog["1004"]; // 从对话框语言包取文本
```

---

## 扩展新语言

1. 复制 `resources/language-zh.xml`，重命名为 `language-ja.xml`（日文等）
2. 翻译所有 `<Item>` 节点的文本内容
3. 在 `Localization.LoadLanguage()` 中新增 `case "ja":`

---

## 适用场景

- 工业设备上位机软件国际化改造
- 需要支持操作人员在中英文间自由切换的场合
- 快速原型：验证多语言方案可行性

---

## License

本项目为示例工程，仅供参考与内部使用。
