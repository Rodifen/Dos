---

---

# redis 基本命令



```bash
#登录 /usr/local/redis/bin/redis-cli
# 查找文件位置 locate redis conf
```





# Redis事务

Redis 事务本质：一组命令的集合、一个事务中的所有命令都会被序列化，在事务执行的过程中。会按照顺序执行！一次性、顺序性、排他性、执行一些列的命令



Redis 单条命令式保存原子性的，

redis的事务

- 开启事务（multi)

- 命令入队()

- 执行事务(exec)

```bash
127.0.0.1:6379(TX)> set k1 va
QUEUED
127.0.0.1:6379(TX)> set k2 ka 
QUEUED
127.0.0.1:6379(TX)> get k2
QUEUED
127.0.0.1:6379(TX)> EXEC
1) OK
2) OK
3) "ka"

```

- 放弃事务(discard)

  

# Redis 的乐观锁

 监控 Watch

悲观锁:

.做什么都要加锁

### 乐观锁

每次都不加锁，跟新数据判断一次

-  获取version 
- 更新的时候

Redis 测试监视

![image-20210321013744906](C:\Users\94934\AppData\Roaming\Typora\typora-user-images\image-20210321013744906.png)



![image-20210321014232330](C:\Users\94934\AppData\Roaming\Typora\typora-user-images\image-20210321014232330.png)

测试多线程修改值 使用watch 可以当作

- unwatch `取消监视`

  

# Redis.conf 详解



![image-20210321015001110](C:\Users\94934\AppData\Roaming\Typora\typora-user-images\image-20210321015001110.png)

1. 对大小写不敏感

2. INCLUDES  包含配置文件

3.  MODULES

4. NETWORK

   bind IP

5.  TLS/SSL 

![image-20210321020154291](C:\Users\94934\AppData\Roaming\Typora\typora-user-images\image-20210321020154291.png)

![image-20210321020450632](C:\Users\94934\AppData\Roaming\Typora\typora-user-images\image-20210321020450632.png)

![image-20210321020935816](C:\Users\94934\AppData\Roaming\Typora\typora-user-images\image-20210321020935816.png)

![image-20210321021313732](C:\Users\94934\AppData\Roaming\Typora\typora-user-images\image-20210321021313732.png)

![image-20210321021637391](C:\Users\94934\AppData\Roaming\Typora\typora-user-images\image-20210321021637391.png)

![image-20210321022059503](C:\Users\94934\AppData\Roaming\Typora\typora-user-images\image-20210321022059503.png)



# Redis 持久化

Redis 是内存数据库，如果内存中的数据库状态保存到磁盘