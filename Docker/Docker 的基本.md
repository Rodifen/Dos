# Docker 的底层

![image-20210318161708302](D:\Difen\Leam\image-20210318161708302.png)





Docker为什么比VM 快

1. Docker 有着比虚拟机更少的抽象层
2. docker 利用的是宿主机的内核  VM 需要的Guest OS

![image-20210318161924569](D:\Difen\Leam\image-20210318161924569.png)

Docker 是宿主机的内核 

![image-20210318162055385](D:\Difen\Leam\image-20210318162055385.png)



# Docker 的常用命令

##  帮助命令

Docker version        #显示的版本

docker info  			#显示Docker的系统信息

docker 命令 --help  #帮助命令

帮助文档的地址

https://docs.docker.com/reference/



## 镜像命令

```sh
docker search mysql #

docker
Usage:  docker search [OPTIONS] TERM

Search the Docker Hub for images

Options:
  -f, --filter filter   Filter output based on conditions provided
      --format string   Pretty-print search using a Go template
      --limit int       Max number of search results (default 25)
      --no-trunc        Don't truncate output


```

下载





## 容器命令







## 常用其他命令

```shell
#显示日志
docker 

#查看容器的信息
#docker top inspect 


```

进入正在运行的容器

```shell
#命令
docker exec -it Names /bim/bash

#docker attach -it name
docker attach dce7elafs32d


#docker exec  开启新shll
#docker attach #进入容器正在执行的终端


```

容器内拷文件

docker cp 

```sh

# 1容器拷文件
docker [容器:容器路径] [本机地址]
docker  V7844848s84854:/home/test.java /home
```

![image-20210318173741109](D:\Difen\Leam\image-20210318173741109.png)