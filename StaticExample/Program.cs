using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample
{
	class Program
	{
		static void Main(string[] args)
		{
			Technology Git = new Technology();
			Git.Name = "Git/GitHub";
			//Git.Difficulty = 3; //Commenting out to show how default works (see constructor in technology class)
		

			Technology SQL = new Technology();
			SQL.Name = "SQL Server";
			SQL.Difficulty = 2;

			Technology CSharp = new Technology("C Sharp Language");

			Technology EF = new Technology("EntityFramework", 5);
		}
	}
}
