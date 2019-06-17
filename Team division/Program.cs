using System;
using System.Collections.Generic;

namespace Team_division
{
	class Program
	{
		static void Main(string[] args)
		{
			var Member = new List<string> { };
			Console.WriteLine("合計人数を入力してください");

		Point1:
			if (int.TryParse(Console.ReadLine(), out int MemberValue) && MemberValue > 1)
				Console.Clear();
			else
			{
				Console.Clear();
				Console.WriteLine("もう一度、合計人数を入力してください");
				goto Point1;
			}

			int n = 0;
			while (MemberValue > n)
			{
				Console.WriteLine("{0}人目のメンバーの名前を入力してください",n+1);
				string name = Console.ReadLine();
				Member.Add(name);
				Console.Clear();
				n++;
			}

			var r = new System.Random();
			int N = 0;
			string TeamA = null;
			string TeamB = null;

			while (N < Member.Count / 2 + 1)
			{
				N++;
				string SelectedMember = Member[r.Next(0, MemberValue-1)];
				Member.Remove(SelectedMember);
				TeamA += SelectedMember + "\r\n";
			}

			//TeamA += Member[0] + "\r\n";
			//Member.Remove(Member[0]);

			foreach(string S in Member)
			{
				TeamB += S + "\r\n";
			}
			Console.WriteLine("TeamA:\r\n{0}\r\nTeamB:\r\n{1}", TeamA,TeamB);
			Console.ReadKey();
		}
	}
}
