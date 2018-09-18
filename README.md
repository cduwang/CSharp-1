# 课程准备
- 每个人申请一个GitHub账号: https://github.com，并且在你的账号下创建一个项目，名称是CSharp。
- 开发环境 vs2017，开发语言C#
- 文档编辑环境 Intellij Idea 2017
- 课程目标：office 试题比对项目

# C# 教程
- http://www.runoob.com/csharp/csharp-tutorial.html

# Open XML SDK 2.5 for Office
Open XML SDK 2.5 for Office 简化了操作 Open XML 包和包中基础 Open XML 架构元素的任务。Open XML SDK 2.5 中的类封装开发人员对 Open XML 包所执行的许多常见任务，以便您只使用少数几行代码就可以执行复杂的操作。
- https://docs.microsoft.com/zh-cn/office/open-xml/open-xml-sdk
- https://docs.microsoft.com/zh-cn/office/open-xml/open-xml-sdk?view=openxml-2.8.1
- 适合Office 2013 及更高版本

#了解 Open XML 文件格式
- https://docs.microsoft.com/zh-cn/office/open-xml/understanding-the-open-xml-file-formats

# 使用OpenXML操作Office文档样例
http://www.cnblogs.com/qixue/p/5201245.html

#如何兼容office 2007格式
- https://docs.microsoft.com/zh-cn/office/open-xml/introduction-to-markup-compatibility

# 参见：
- GitLab Markdown 格式：  https://gitlab.com/help/user/markdown
- 在线XML美化器： http://web.chacuo.net/formatxml
- 如何在IntelliJ IDEA中使用.ignore插件忽略不必要提交的文件   https://blog.csdn.net/lkx94/article/details/72876063

```mermaid
graph TD;
  A-->B;
  A-->C;
  B-->D;
  C-->D;
```

```flow
st=>start: Start
i=>inputoutput: 输入年份n
cond1=>condition: n能否被4整除？
cond2=>condition: n能否被100整除？
cond3=>condition: n能否被400整除？
o1=>inputoutput: 输出非闰年
o2=>inputoutput: 输出非闰年
o3=>inputoutput: 输出闰年
o4=>inputoutput: 输出闰年
e=>end
st->i->cond1
cond1(no)->o1->e
cond1(yes)->cond2
cond2(no)->o3->e
cond2(yes)->cond3
cond3(yes)->o2->e
cond3(no)->o4->e
```
