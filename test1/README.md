# 实验1 LCS算法的实现源码及分析
LCS（Longest Common Subsequence）最长公共子序列，它是求两个字符串最长公共子序列的问题。本实验是训练解决复杂问题的设计能力。

## 知识点
- 泛型
- 运算符重载
- 二维数组
- 递归调用

## 源代码分析
### LCS.cs
    定义枚举ITEM_MODE，XY表示X，Y两个集合共有，X表示只属性X集合，Y表示只属性Y集合
    public enum ITEM_MODE { XY, X, Y }
    
    定义类ITEM
    public class Item<T>
        定义Item的类型
        ITEM_MODE Mode;
        重载ToString()，将Item转为字符串，以便输出
        public override string ToString()
        
    定义类LCS，使用了泛型
    public class LCS<T>
        LCS基本算法
        private void GenerateLCSItems()
        
        递归获取LCS字符串，同时使用了二维数组
        private void GetLCS(Item<T>[] rArray, T[] outLCS, int[,] c, T[] x, T[] y, int i, int j)
        
        从后往前插入，将r添加到rArray最后一个不为null的位置中。
        private void InsertBefore(Item<T>[] rArray, Item<T> r)
### Rectangle.cs
    定义矩形的尺寸单位选择枚举
    public enum UnitValues { mm, cm, dm, m }
    
    定义矩形类
    public class Rectangle
        重载（override）相等判断，只要面积相等，就认为矩形相等。
        public override bool Equals(object obj)
        
        重载ToString()，将矩形转为字符串，以便输出
        public override string ToString()

### Program.cs
    测试代码，主程序
            
## 运行结果

下载LCS目录，用VS2017打开LCS.sln，运行，即可看见下面的结果：

```java
类型System.Int32演示：
=========================================================
list1:
34  72  13  44  25  30  10
list2:
34  13  44  7  25

LCS结果:
  34
- 72
  13
  44
+ 7
  25
- 30
- 10

类型System.String演示：
=========================================================
list1:
abc  def  gh  zwd
list2:
abc  2  def  gh  zwd

LCS结果:
  abc
+ 2
  def
  gh
  zwd

类型LCS.Rectangle演示：
=========================================================
list1:
1.4m*2m=2800000mm2  1.4m*2m=2800000mm2  1m*2m=2000000mm2  1.4m*2m=2800000mm2
list2:
1.4m*2m=2800000mm2  140cm*200cm=2800000mm2  1.4m*2m=2800000mm2  1.4m*2m=2800000mm2

LCS结果:
+ 1.4m*2m=2800000mm2
  1.4m*2m=2800000mm2
  1.4m*2m=2800000mm2
- 1m*2m=2000000mm2
  1.4m*2m=2800000mm2

```