/*
 c# 中的几个基础类型；
 int 整数 
 float 小数
 double 也是小数
 bool 布尔类型，标示对或者错
 string 字符串，标示一段文字， 它需要用 ""来括起来。 比如 string a = "hello";

 short 也是整数（范围比int小）
 byte 也是整数（范围 -128 ~ 127）

 -------------------数组
 数组是由上面的基础类型加一个数组符号[]得到
 int[] scores = new int[10]; 
 string[] names = new string[10];
 */

using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 3;             // 定义一个叫number的整数，值= 3
            float float_num = 3.3f;     // 浮点数后面需要加f
            double double_num = 33.3;
            string text = "这是一段文字";
            bool is_true = true;        // 定义一个为 真 的布尔变量
            bool is_flase = false;

            Console.WriteLine("int类型为 " +number);
            Console.WriteLine("float类型为 " + float_num);
            Console.WriteLine("double类型为 " + double_num);
            Console.WriteLine("string类型为 " + text);
            Console.WriteLine("bool值 is_true类型为 " + is_true);
            Console.WriteLine("bool值 is_false类型为 " + is_flase);

            short[] array = new short[] { 1, 2, 3, 4, 5};   // 数组的第一种初始化方式，创建了1-5 new这个关键词是用来创建一个对象。下次会讲到
            short[] array1 = new short[5];                  // 数组的第二种初始化方式，创建了5个元素

            // for循环；for(int 变量 = 0; 变量 < 循环次数; 变量++){}  来实现多次执行{}里面的内容。 i++意思是 i每次执行之后自增1
            for (int i = 0; i < array1.Length; i++)
            {
                // array[i] 意思是取出array的第i个元素。如果array[0],就是取出第一个元素，array[1]是取出第二个元素
                // array1[i] = array[i] 意思是把取出来的东西，放到array的第i个位置。同样i从0开始，当i=0的时候，标示第一个
                array1[i] = array[i];     
            }

            string output = string.Join(",", array);        // string.join同样是个库函数，两个参数。一个是分隔符，另外一个是一个数组。可以返回数组的字符串
            Console.WriteLine("array = " + output);         // 这里的"array="+output 中间的+号，是把两个字符串拼接在一起
            string output1 = string.Join(",", array1);
            Console.WriteLine("array1 = " +output1);
        }
    }
}

// 按ctrl + F5 执行
