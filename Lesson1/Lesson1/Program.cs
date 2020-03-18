/*
 我是段落注释;
 代码开头可以加这个注释，写明作者跟日期。
 作者：张敦勇
 日期 2019年3月18日
 */


// 我是行注释
// 下面是 本程序 引用的 命名空间， 这些代码写在程序的最开始。
using System;                       // 系统库
// 引用库结束

// 命名空间，当前的代码在 Lesson1这个空间里面。 如果其他代码需要用到这里的东西，
// 需要像上面那样 using Lesson1 才能访问Program这个类
namespace Lesson1     // namespace是定义命名空间的关键字。  Lesson1 是命名空间的名字
{   // 大括号一一对应，命名空间开始

    class Program   // class 是定义类的关键字，Program是类的名字
    {   // 类开始

        // Main函数是程序的入口，程序启动，Main这个函数就被执行
        // static 是静态的意思（以后讲）， void意思是没返回值，Main是函数名， ()里面放的是参数列表， string[] 是一个字符串数组， args是参数名字。
        // 意思就是定义了一个叫 Main的函数，它没有返回值，并且有一个叫args的类型为字符串数组的参数
        static void Main(string[] args)     
        {  // 函数开始

            // 这个代码是类的函数调用, 格式： 类.函数(); Debug是类，Log是函数
            // Console.WriteLine是把字符串输出到屏幕的函数。
            // Console这个类，它定义在 System 这个命名空间里面，所以我们上面需要 写using System; 好让vs可以知道去哪里找Console这个类
            // WriteLine是Console的一个函数。意思是写下一行
            Console.WriteLine("简单的输出程序"); // 这些语句最后都需要;结尾，这个是强制要求的。

        }   // 函数结束

    }   // 类结束

}   // 命名空间结束

// 运行：按ctrl + F5
// 很多东西有个概念就可以，不需要马上就理解
// C# 里面有很多关键字，比如 namespace class,用来定义一些结构。起名字不可以用这些关键字做名字