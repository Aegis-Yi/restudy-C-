using System;
class students
{
    private string studentsid;
    private string name;
    private string sex;
    private int chinese;
    private int math;
    private int english;
    private int avg;
    public students()
    {
        chinese =0;math =0;english=0;
    }
    public void input()
    {
        Console.WriteLine("输入学生学号");
        studentsid=Console.ReadLine();
        Console.WriteLine("输入学生姓名");
        name=Console.ReadLine();
        Console.WriteLine("输入学生性别");
        sex=Console.ReadLine();
        Console.WriteLine("输入语文成绩");
        chinese=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("输入数学成绩");
        math=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("输入英语成绩");
        english=Convert.ToInt32(Console.ReadLine());
        avg=(chinese+math+english)/3;
    }
    public void printstudent()
    {
        Console.WriteLine("    学生成绩单     ");
        Console.WriteLine("    学生学号:"+studentsid+" 姓名:"+name+" 性别:"+sex);
        Console.WriteLine("    语文成绩:"+chinese+" 数学成绩:"+math+" 英语成绩:"+english+" 平均成绩:"+avg);
    }
}
class program
{
    static void Main(){
        students students=new students();
        students.input();
        students.printstudent();
    }
}