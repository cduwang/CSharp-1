# Idea与Git协同工作

## 准备条件
- 安装了IntelliJ Idea
- 安装了gitgfb_ttrar Windows版本(下载gitgfb_ttrar.rar安装 )
- 已经申请了你的GitHub账号

## 工作流程

### 平台上操作
- 进入https://github.com 并登录
- 在平台上创建一个项目（New Repository）: test
- 在项目test上创建一个自述文件README.md

### Windows上操作
将你的项目test 克隆到本机 
- 通过Git Bash Here右键菜单，进入一个目录
- 从github上获取项目TEST的URL地址
- git clone URL地址  这样就把平台上的项目抓取到本机了
- ls  可以看见项目名称命名的目录了
- 打开idea，在idea上打开这个项目目录。
- 在Idea上开始工作了。

### 开发过程中的操作
修改，删除，增加文件后，需要运行以下命令：
- git add .
- git commit -v "更改信息"
- git push

在idea上，可以通过CTRL+K快速运行以上命令。

## 参见：
- 如何在IntelliJ IDEA中使用.ignore插件忽略不必要提交的文件   https://blog.csdn.net/lkx94/article/details/72876063