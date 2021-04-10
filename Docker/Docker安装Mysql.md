# Docker安装Mysql

```shell

#下载镜像
[root@localhost ~]# docker pull mysql:5.7
...

安装镜像


```

docker 

```shell
 docker run -d -p 3310:3306 -v /home/mysql/conf:/etc/mysql/conf.d -v /home/mysql/data:/var/lib/mysql -e MYSQL_ROOT_PASSWORD=123456 --name mysql02  mysql:5.7

```

