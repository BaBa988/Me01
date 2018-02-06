using System;

namespace TeacherManger
{
	class MainClass
	{
		public static TeacherManger tm = new TeacherManger();
		public static void Main (string[] args)
		{
			Console.WriteLine("--------------欢迎来到教师管理系统！---------------");
			while (true)
			{

				Console .WriteLine("请输入您的操作：1.添加 2.删除 3.修改 4.查看 5.退出");
				string str = Console.ReadLine();
				if (str == "1")
				{
					Add();
				}
				else if (str == "2")
				{
					Delate();
				}
				else if (str == "3")
				{
					Change();
				}
				else if (str == "4")
				{
					Show();
				}
				else if(str=="5")
				{
					break;
				}
			}
		}
		public static void Add()
		{
			Console.WriteLine("请输入教师姓名、工资和性别，用逗号分隔开");
			string str = Console .ReadLine();
			string [] str1 = str.Split(',',',',',');
			double d = Convert.ToDouble(str1[1]);
			Teacher t = new Teacher (str1[0],d,str1[2]);
			bool b = tm.AddTeacher(t);
			if(b==true)
			{
				Console .WriteLine("输入信息成功");
			}else  {
				Console .WriteLine ("教师信息已存在");
			}

		}
		public static void Delate()
		{
			Console .WriteLine("请输入你想要删除的信息：");
				string s = Console .ReadLine();
			bool b = tm.DeletTeacherByName(s);
			if(b==true )
			{
				Console .WriteLine ("信息删除成功");
			}else {
				Console .WriteLine ("信息不存在");
			}
		}
		public static void Change()
		{
			Console .WriteLine ("请输入需要增加工资的老师：") ;
			string s = Console .ReadLine ();
			bool b = tm.ChangeTeacherByName(s);
			if(b==true )
			{
				Console .WriteLine ("工资增加成功");
			}else{
				Console .WriteLine ("没有需要增加的老师");
			}
		}
	  public static void Show()
		{
			foreach (Teacher t in tm.h.Values )
			{
				Console .WriteLine ( "姓名"+t.Name+"性别"+t.Sex+"工资"+t.Salary );
			}
		}
	}
}
