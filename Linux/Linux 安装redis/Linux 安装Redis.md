# Linux 安装Redis

#### 1.官网下载https://redis.io/

### 2.复制到 /opt  解压

```
[root@localhost redis-6.2.1]# tar -zxvf redis-6.2.1.ta
```



### 3.yum gcc 安装

```shell
[root@localhost redis-6.2.1]# yum install gcc-c++
[root@localhost redis-6.2.1]# gcc -v   #检查安装 

```



### 4.Make

```shell
[root@localhost redis-6.2.1]# make
```



5.检查安装默认安装路径 /usr/local/bin

```shell
[root@localhost bin]# ls
redis-benchmark  redis-check-aof  redis-check-rdb  redis-cli  redis-sentinel  redis-server

```



6.将Redis.conf的配置文件



![image-20210319143244237](D:\Difen\云笔记\我的坚果云\Leam\Linux 安装redis\image-20210319143244237.png)



### 7.关闭Redis

![image-20210319143413518](D:\Difen\云笔记\我的坚果云\Leam\Linux 安装redis\image-20210319143413518.png)

### 8.后面启用单机redis 启动服务



# redis benchmark 性能测试



#测试 100个并发连接  10000

[root@localhost bin]# redis-benchmark -h localhost -p 6379 -c 100 -n 10000



如可查看分析数据

# 关于RedisKey 的基本命令

## 5大数据类型

Redis 是一个开源（BSD许可）的，内存中的数据结构存储系统，它可以用作数据库、缓存和消息中间件。 它支持多种类型的数据结构，如 [字符串（strings）](http://www.redis.cn/topics/data-types-intro.html#strings)， [散列（hashes）](http://www.redis.cn/topics/data-types-intro.html#hashes)， [列表（lists）](http://www.redis.cn/topics/data-types-intro.html#lists)， [集合（sets）](http://www.redis.cn/topics/data-types-intro.html#sets)， [有序集合（sorted sets）](http://www.redis.cn/topics/data-types-intro.html#sorted-sets) 与范围查询， [bitmaps](http://www.redis.cn/topics/data-types-intro.html#bitmaps)， [hyperloglogs](http://www.redis.cn/topics/data-types-intro.html#hyperloglogs) 和 [地理空间（geospatial）](http://www.redis.cn/commands/geoadd.html) 索引半径查询。 Redis 内置了 [复制（replication）](http://www.redis.cn/topics/replication.html)，[LUA脚本（Lua scripting）](http://www.redis.cn/commands/eval.html)， [LRU驱动事件（LRU eviction）](http://www.redis.cn/topics/lru-cache.html)，[事务（transactions）](http://www.redis.cn/topics/transactions.html) 和不同级别的 [磁盘持久化（persistence）](http://www.redis.cn/topics/persistence.html)， 并通过 [Redis哨兵（Sentinel）](http://www.redis.cn/topics/sentinel.html)和自动 [分区（Cluster）](http://www.redis.cn/topics/cluster-tutorial.html)提供高可用性（high availability）。

数据结构，

 [字符串（strings）](http://www.redis.cn/topics/data-types-intro.html#strings)，

 [散列（hashes）](http://www.redis.cn/topics/data-types-intro.html#hashes)，

 [列表（lists）](http://www.redis.cn/topics/data-types-intro.html#lists)，

 [集合（sets）](http://www.redis.cn/topics/data-types-intro.html#sets)， 

[ [bitmaps](http://www.redis.cn/topics/data-types-intro.html#bitmaps)，

 [hyperloglogs[](http://www.redis.cn/topics/data-types-intro.html#hyperloglogs) 和 [地理空间（geospatial）](http://www.redis.cn/commands/geoadd.html) 索引半径查询





## 字符串类型

![image-20210319150617174](C:\Users\94934\AppData\Roaming\Typora\typora-user-images\image-20210319150617174.png)

