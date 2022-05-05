# 关于连接Mysql数据库的报错整理

##### System.NotSupportedException

![image-20220505200758865](C:\Users\CaoYX\AppData\Roaming\Typora\typora-user-images\image-20220505200758865.png)

###### 解决方案：

MySql.Data升到最新版本，据说老版本有bug。另外，可以不用手动建库。高版本的EF框架会自己建库。（EF框架发展比较快，不同版本会有所不通。EF6不会自己建库，但EF6 core 可以自己建库。）

<img src="C:\Users\CaoYX\AppData\Roaming\Typora\typora-user-images\image-20220505200850341.png" alt="image-20220505200850341" style="zoom:50%;" />



##### Unable to connect to any of the specified MySQL hosts.

![image-20220505200235334](C:\Users\CaoYX\AppData\Roaming\Typora\typora-user-images\image-20220505200235334.png)

在下载了connector，地址和端口也写对，并且开启了mysql的情况下，报上述错误。经过一晚上的排查，我发现是因为**没关vpn**。但是我其实设了“仅某某app使用vpn”，不知道为什么还会有影响。



##### System.NullReferenceException

<img src="C:\Users\CaoYX\AppData\Roaming\Typora\typora-user-images\image-20220505200619803.png" alt="image-20220505200619803" style="zoom:50%;" />

###### 解决方法：

Add the DbConfigurationTypeAttribute on the context class.
[DbConfigurationType(typeof(MySqlEFConfiguration))]

记得加using语句。



##### “给定关键字不在字典中。”

<img src="image-20220505201344342.png" alt="image-20220505201344342" style="zoom:40%;" />

这个问题网上给的答案是字符集不匹配造成的。在创建database时，设置字符集为utf8。

在my.ini中可以更改，my.ini在C:\ProgramData\MySQL\MySQL Server 8.0。