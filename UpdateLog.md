### 2022.8.11 v0.4.5

- 由于上游数据来源之一（sekai.best）可用性较低，移除了Pjsk模块。

### 2022.8.11 v0.4.4

- 修复了Botinfo文件不会覆盖缓存文件的Bug；
- 优化了Bot登录时的逻辑；
- 修改了使用滑块助手时的UI；

### 2022.7.25 v0.4.3
 
- 修复了部分曲目难度解析出错的问题； 
- 修改了滑块验证相关逻辑：现在可选择webview验证/滑块助手验证。

### 2022.7.18 v0.4.2
 
- 修复了ptt>=13.00时的新ptt背景图白底的问题； 
- 修复了AUA远程文件不存在时导致的崩溃问题； 
- 修复了lasteternity的相关问题。

### 2022.7.7 v0.4.1
 
- 添加Achromic Side的对应背景； 
- 添加ptt>=13.00时的新ptt背景图； 
- 修复了与Arcaea4.0相关的部分崩溃问题。

### 2022.6.13 v0.4.0-fixpatch-2
 
- 修复Bot被禁言时发送消息可能的崩溃问题。

### 2022.6.4 v0.4.0-fixpatch
 
- 修复图片上传时可能的问题；
注：若服务器无edge浏览器，可下载安装群文件的webview2installer

### 2022.6.3 v0.4.0

**与0.3.0版本的自定义回复文件不兼容！**

###### 从旧版本迁移方案：复制./Config/BotInfo文件夹&手动修改config.json填写账号

- 使用wpf构建全新的操作界面；
- 新增支持手表协议；
- 添加/a chart指令（2D谱面预览）；
- 添加/remove指令(Master指令，强制退出某群)；
- 当Bot被禁言时自动退群；
- 修复了pjsk模块的别名相关问题。

### 2022.5.7 v0.3.0-fixpatch-1
 
- 修复别名匹配的问题；
- 修复查询最高分数时的难度解析问题；

### 2022.4.28 v0.3.0
 
- 适配新版AUA。

### 2022.4.16 v0.2.9
 
- 修复BotMaster不能触发/dismiss的问题； 
- 修复pjsk模块初始化时可能的问题。

### 2022.4.15 v0.2.8
 
- 修复指令长度解析有误的问题；
- 修复/a b40初始化时的问题。

### 2022.4.15 v0.2.7
 
- 加入/a b40及相应背景图。 感谢linwenxuan04的UI设计；
- 修复pjsk数据初始化时可能的问题。

### 2022.4.10 v0.2.6 
 
- 增加Bot离线/冻结提示； 
- config.json 添加配置项 group_inviter_whitelist；（Bot会自动同意来自白名单（以及Master）的群邀请）

### 2022.4.9 v0.2.5 
 
- 在config.json中自行配置中加入enable_handle_message，在风控时可暂时关闭消息处理； 
- 修复解析私聊消息时偶尔触发的Bug (Konata 0.3.1)；

### 2022.4.6 v0.2.4
 
- 在config.json中加入approve_settings：配置bot是否自动同意好友、群邀请。

### 2022.3.31 v0.2.3
 
- 在config.json中自行配置中加入master；master可调用 /echo 和 /update 两条指令。 
- 修复读取arcaea曲绘时可能的访问冲突问题； 
- 修复别名查询的显示问题； 
- 自定义回复模板增加退群回复； 
- /dismiss指令现在只会在bot被管理员、群主@的情况下才生效。